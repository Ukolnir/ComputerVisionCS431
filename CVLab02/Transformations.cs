using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVLab02
{
    class Transformations
    {
        public static int[] RGBtoGrey(Bitmap src, ref Bitmap dest) {
            dest = new Bitmap(src.Width, src.Height);
            int[] intensity = new int[256];
            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y){
                    var t = src.GetPixel(x, y);
                    double c = 0.2126 * t.R + 0.7152 * t.G + 0.0722 * t.B;
                    ++intensity[(int)c];
                    dest.SetPixel(x, y, Color.FromArgb((int)c, (int)c, (int)c));
                }
            return intensity;
        }

        static Color[] colors = new Color[] { Color.Gainsboro, Color.LightGreen, Color.Goldenrod,
            Color.OrangeRed, Color.Cyan, Color.DarkCyan, Color.Bisque, Color.YellowGreen };

        public static Bitmap QuantizationImage(Bitmap src, int level) {
            Bitmap dest = new Bitmap(src.Width, src.Height);
            var sl = 255 / level;
            List<int> limits = new List<int>();
            for (int i = sl; i < 256; i += sl)
                limits.Add(i); //наверно где-то есть не убогий способ, но я туплю

            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y) {
                    var t = src.GetPixel(x, y);

                    var first = limits.FindIndex(c => c > t.R);

                    if (first == -1)
                        dest.SetPixel(x, y, colors[level - 1]);
                    else
                        dest.SetPixel(x, y, colors[first]);
                }
            return dest;
        }

        //true - нижняя пороговая бинаризация
        public static Bitmap Binarization(Bitmap src, int limit, bool typeBin = false) {
            Bitmap dest = new Bitmap(src.Width, src.Height);
            Color b = Color.Black, w = Color.White;
            if (typeBin) {
                b = Color.White;
                w = Color.Black;
            }
            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y){
                    var t = src.GetPixel(x, y);
                    if(t.R < limit)
                        dest.SetPixel(x, y, b);
                    else
                        dest.SetPixel(x, y, w);
                }
            return dest;
        }

        public static Bitmap BinarizationD(Bitmap src, int limit1, int limit2){
            Bitmap dest = new Bitmap(src.Width, src.Height);
            Color b = Color.Black, w = Color.White;

            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y){
                    var t = src.GetPixel(x, y);
                    if (t.R < limit2 && t.R > limit1)
                        dest.SetPixel(x, y, w);
                    else
                        dest.SetPixel(x, y, b);
                }
            return dest;
        }

        public static Bitmap GlobalOtsu(Bitmap src, int[] intensity) {
            Bitmap dest = new Bitmap(src.Width, src.Height);
            Color b = Color.Black, w = Color.White;
            double[] disp = new double[256];

            int q = intensity[0];
            double m1 = 0, m2 = 0;
            double nt = 0, mt = 0;
            for (int i = 0; i < 255; ++i) {
                nt += intensity[i];
                mt += intensity[i] * i;
            }
            mt /= nt;

            for (int i = 1; i < 255; ++i) {
                m1 = q * m1 + i * intensity[i];
                q += intensity[i];
                m2 = (mt - q * m1) / (1 - q);
                disp[i] = q * (1 - q) * (m1 - m2)*(m1-m2);
            }

            var lst = disp.ToList();
            int maxT = lst.FindIndex(x => x == lst.Max());

            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y){
                    var t = src.GetPixel(x, y);
                    if (t.R < maxT)
                        dest.SetPixel(x, y, b);
                    else
                        dest.SetPixel(x, y, w);
                }
            return dest;
        }
    }
}