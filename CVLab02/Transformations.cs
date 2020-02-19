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

        public static Bitmap QuantizationImage(Bitmap src, int[] intensity, int level) {
            Bitmap dest = new Bitmap(src.Width, src.Height);

            for (int x = 0; x < dest.Width; ++x)
                for (int y = 0; y < dest.Height; ++y) {
                    var t = src.GetPixel(x, y);
                    if (t.R < 255 / level)
                        dest.SetPixel(x, y, colors[0]);
                    else
                        dest.SetPixel(x, y, colors[1]);
                }
            return dest;
        }
    }
}
