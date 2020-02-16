using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace CVLab01{
    public class Common {
        public static int Clip(int val) => val > 255 
            ? 255 : (val < 0 ? 0 : val);
    }

    public class YUV{
        public double Y { get; set; }
        double U, V;

        public YUV(double y, Color c){
            Y = y;
            U = -0.0999 * c.R - 0.3360 * c.G + 0.4360 * c.B;
            V = 0.6150 * c.R - 0.5586 * c.G - 0.0563 * c.B;
        }

        public Color ToRGB(){
            int R = (int)(Y + 1.2803 * V);
            int G = (int)(Y - 0.2148 * U - 0.3805 * V);
            int B = (int)(Y + 2.1279 * U);
            return Color.FromArgb(
                Common.Clip(R),
                Common.Clip(G),
                Common.Clip(B));
        }
    }
}
