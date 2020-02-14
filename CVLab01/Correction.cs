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

    public class CorrectionWithBasicColor : Correction{
        public Color ColorSource { get; set; }
        public Color ColorDestination { get; set; }

        public CorrectionWithBasicColor(Bitmap bitmap) : base(bitmap)
        {
        }

        public Bitmap Transform() {
            Bitmap result = new Bitmap(SourceImage.Width, SourceImage.Height);
            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y){
                    Color source = SourceImage.GetPixel(x, y);
                    Color replace = Color.FromArgb((source.R * (ColorDestination.R / ColorSource.R)) % 256,
                        (source.G * (ColorDestination.G / ColorSource.G)) % 256,
                        (source.B * (ColorDestination.B / ColorSource.B)) % 256);
                    result.SetPixel(x, y, replace);
                }
            return result;
        }
    }
}
