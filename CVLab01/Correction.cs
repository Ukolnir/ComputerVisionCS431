using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVLab01
{
    public class Correction{
        public Bitmap SourceImage { get; }

        public Correction(Bitmap bitmap) {
            SourceImage = bitmap;
        }
    }

    public class HistCorrection : Correction{
        public HistCorrection(Bitmap bitmap) : base(bitmap){}
        public Bitmap GreyImage { get; set; }
        public Bitmap ColorImage { get; set; } //после трансформации
        public int[] IntensitySource = new int[256];
        public int[] IntensityAfterTransform;
        internal YUV[,] yuvImage;

        public Bitmap RGBtoGrey(){
            GreyImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            yuvImage = new YUV[SourceImage.Width, SourceImage.Height];
            for (int x = 0; x < GreyImage.Width; ++x)
                for (int y = 0; y < GreyImage.Height; ++y){
                    var t = SourceImage.GetPixel(x, y);
                    double c = 0.2126 * t.R + 0.7152 * t.G + 0.0722 * t.B;
                    ++IntensitySource[(int)c];
                    GreyImage.SetPixel(x, y, Color.FromArgb((int)c, (int)c, (int)c));
                    yuvImage[x, y] = new YUV(c, t);
                }
            return GreyImage;
        }

        public void Clear() {
            GreyImage = null;
            ColorImage = null;
            IntensitySource = new int[256];
        }
    }

    public class CorrectionWithEqualizationHist : HistCorrection {
        public CorrectionWithEqualizationHist(Bitmap bitmap) : base(bitmap) { }

        public Bitmap Transform() {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            ColorImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            IntensityAfterTransform = new int[256];
            double[] temp = new double[256];
            double n = SourceImage.Width * SourceImage.Height * 1.0;
            for (int i = 0; i < 256; ++i)      
                temp[i] = IntensitySource[i] / n;
            for (int i = 1; i < 256; ++i) temp[i] += temp[i - 1];

            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y) {
                    yuvImage[x, y].Y = temp[Common.Clip((int)(yuvImage[x, y].Y))] * 255;
                    var ytemp = Common.Clip((int)yuvImage[x, y].Y);
                    ++IntensityAfterTransform[ytemp];
                    result.SetPixel(x, y, Color.FromArgb(
                        ytemp,
                        ytemp,
                        ytemp));
                    ColorImage.SetPixel(x, y, yuvImage[x, y].ToRGB());
                }
            return result;
        } 
    }


    public class FunctionCorrection : HistCorrection {
       
        public FunctionCorrection(Bitmap bitmap): base(bitmap){
            
        }

        public Tuple<int, int> getMinMaxIntens() {
            int max = 255, min = 0;
            for (int i = 0; i < 256; ++i)
                if (IntensitySource[i] != 0){
                    min = i;
                    break;
                }

            for (int i = 255; i >= 0; --i)
                if (IntensitySource[i] != 0){
                    max = i;
                    break;
                }
            return Tuple.Create(min, max);
        }

        public Bitmap TransformWithLinearCorrection(int min, int max) {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            ColorImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            IntensityAfterTransform = new int[256];

            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y){
                    yuvImage[x, y].Y = (yuvImage[x, y].Y - min) * 255 
                                            / (max - min);
                    var ytemp = Common.Clip((int)yuvImage[x, y].Y);
                    ++IntensityAfterTransform[ytemp];
                    result.SetPixel(x, y, Color.FromArgb(
                        ytemp,
                        ytemp,
                        ytemp));
                    ColorImage.SetPixel(x,y, yuvImage[x, y].ToRGB());
                }
            return result;
        }

        public Bitmap TransformWithGammaCorrection(double gamma = 1) {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            ColorImage = new Bitmap(SourceImage.Width, SourceImage.Height);
            IntensityAfterTransform = new int[256];

            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y) {
					yuvImage[x, y].Y /= 255;
					yuvImage[x, y].Y = Math.Pow(yuvImage[x, y].Y, 1/gamma);
					yuvImage[x, y].Y *= 255;
                    var ytemp = Common.Clip(((int)yuvImage[x, y].Y));
                    ++IntensityAfterTransform[ytemp];
                    result.SetPixel(x, y, Color.FromArgb(
                        ytemp,
                        ytemp,
                        ytemp));
                    ColorImage.SetPixel(x, y, yuvImage[x, y].ToRGB());
                }
            return result;
        }

    }

    //Коррекция с опорным цветом
    public class CorrectionWithBasicColor : Correction{
        public Color ColorSource { get; set; }
        public Color ColorDestination { get; set; }

        public CorrectionWithBasicColor(Bitmap bitmap) : base(bitmap){}

        public Bitmap Transform() {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y){
                    Color source = SourceImage.GetPixel(x, y);
                    Color replace = Color.FromArgb(
                        Common.Clip(source.R * (ColorDestination.R / ColorSource.R)),
                        Common.Clip(source.G * (ColorDestination.G / ColorSource.G)),
                        Common.Clip(source.B * (ColorDestination.B / ColorSource.B)));
                    result.SetPixel(x, y, replace);
                }
            return result;
        }
    }

    //Серый мир
    public class CorrectionGreyWorld : Correction {
        public CorrectionGreyWorld(Bitmap bitmap) : base(bitmap) { }
        public Bitmap Transform() {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            var cntPix = SourceImage.Width * SourceImage.Height;  //N
            int r = 0;
            int g = 0;
            int b = 0;

            for (int x = 0; x < SourceImage.Width; ++x)
                for (int y = 0; y < SourceImage.Height; ++y) {
                    var t = SourceImage.GetPixel(x, y);
                    r += t.R;
                    g += t.G;
                    b += t.B;
                }
            r /= cntPix;  //Можно сократить, используя арифметику, 
            g /= cntPix;  //но теряется понимание формулы
            b /= cntPix;

            var avg = (r + b + g) / 3;

            for (int x = 0; x < SourceImage.Width; ++x)
                for (int y = 0; y < SourceImage.Height; ++y) {
                    var t = SourceImage.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(t.A,
                        Common.Clip(t.R * avg / r),
                        Common.Clip(t.G * avg / g),
                        Common.Clip(t.B * avg / b)));
                }
            return result;
        }
    }
}
