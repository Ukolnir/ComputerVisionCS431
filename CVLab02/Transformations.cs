using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		static int MethodOtsu(int cntPix, int[] intensity){
			double[] disp = new double[intensity.Length];
			double[] intensityD = new double[intensity.Length];
			for (int i = 0; i < intensity.Length; ++i)
				intensityD[i] = 1.0 * intensity[i] / cntPix;

			double q = intensityD[0];
			double m1 = 0, m2 = 0;
			double nt = 0, mt = 0;
			for (int i = 0; i < intensity.Length; ++i){
				nt += intensityD[i];
				mt += intensityD[i] * i;
			}
			mt /= nt;

			for (int i = 1; i < intensity.Length; ++i)
			{
				m1 = q * m1 + i * intensityD[i];
				q += intensityD[i];
				if (q == 0 || q == 1) continue;
				m1 /= q;
				m2 = (mt - q * m1) / (1 - q);
				disp[i] = Math.Sqrt(q * (1 - q) * (m1 - m2) * (m1 - m2));
			}

			var lst = disp.ToList();
			var t = lst.FindIndex(x => x == lst.Max());
			Console.WriteLine("Otsu T: " + t);
			return t;
		}

		static void RecMethodOtsu(double[] intensity, List<int> listT, int cntRec){
			if (cntRec == 0 || intensity.Length < 3) return;
			double[] disp = new double[intensity.Length];
		

			double q = intensity[0];
			double m1 = 0, m2 = 0;
			double nt = 0, mt = 0;
			for (int i = 0; i < intensity.Length; ++i)
			{
				nt += intensity[i];
				mt += intensity[i] * i;
			}
			mt /= nt;

			for (int i = 1; i < intensity.Length; ++i)
			{
				m1 = q * m1 + i * intensity[i];
				q += intensity[i];
				if (q == 0 || q == 1) continue;
				m1 /= q;
				m2 = (mt - q * m1) / (1 - q);
				disp[i] = Math.Sqrt(q * (1 - q) * (m1 - m2) * (m1 - m2));
			}

			var lst = disp.ToList();
			var t = lst.FindIndex(x => x == lst.Max());
			listT.Add(t);

			double[] tempInten = new double[t];
			for (int i = 0; i < t; ++i)
				tempInten[i] = intensity[i];

			RecMethodOtsu(tempInten,listT,cntRec-1);

			double[] tempInten1 = new double[intensity.Length - t + 1];
			for (int i = t; i < intensity.Length; ++i)
				tempInten1[i-t] = intensity[i];
			RecMethodOtsu(tempInten1, listT, cntRec - 1);
		}

		public static Bitmap GlobalOtsu(Bitmap src, int[] intensity) {
            Bitmap dest = new Bitmap(src.Width, src.Height);
            Color b = Color.Black, w = Color.White;

            var maxT = MethodOtsu(src.Width*src.Height, intensity);
			Console.WriteLine();
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

        public static Bitmap LocalOtsu(Bitmap src) {
            Bitmap dest = new Bitmap(src.Width, src.Height);
			Color b = Color.Black, w = Color.White;

			int[] inten1 = new int[256], inten2 = new int[256];
			for (int x = 0; x < dest.Width; ++x){
				for (int y = 0; y < dest.Height / 2; ++y)
					++inten1[src.GetPixel(x, y).R];
				for (int y = dest.Height / 2; y < dest.Height; ++y)
					++inten2[src.GetPixel(x, y).R];
			}

			var maxT1 = MethodOtsu(src.Width * src.Height, inten1);
			var maxT2 = MethodOtsu(src.Width * src.Height, inten2);

			Console.WriteLine();

			for (int x = 0; x < dest.Width; ++x){
				for (int y = 0; y < dest.Height / 2; ++y) {
					var t = src.GetPixel(x, y);
					if (t.R < maxT1)
						dest.SetPixel(x, y, b);
					else
						dest.SetPixel(x, y, w);
				}
				for (int y = dest.Height / 2; y < dest.Height; ++y) {
					var t = src.GetPixel(x, y);
					if (t.R < maxT2)
						dest.SetPixel(x, y, b);
					else
						dest.SetPixel(x, y, w);
				}
			}
			return dest;
        }

		public static Bitmap IerarhOtsu(Bitmap src, int[] intensity){
			Bitmap dest = new Bitmap(src.Width, src.Height);
			Color b = Color.Black, w = Color.White;

			List<int> listT = new List<int>();

			var cntPix = src.Width * src.Height;
			double[] intensityD = new double[256];
			for (int i = 0; i < intensity.Length; ++i)
				intensityD[i] = 1.0 * intensity[i] / cntPix;

			RecMethodOtsu(intensityD, listT, 4);
			listT = listT.OrderBy(x=>x).ToList();

			for (int x = 0; x < dest.Width; ++x)
				for (int y = 0; y < dest.Height; ++y){
					var t = src.GetPixel(x, y);

					var first = listT.FindIndex(c => c > t.R);

					if (first % 2 == 0)
						dest.SetPixel(x, y, b);
					else
						dest.SetPixel(x, y, w);
				}
			return dest;
		}
	}
}
//Когда-нибудь я отрефакторю код, но не сейчас
											  