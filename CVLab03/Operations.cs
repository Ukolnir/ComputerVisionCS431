using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVLab03
{
	class Operations{

		public static int[,] BitmapToArr(Bitmap src) {
			var dest = new int[src.Width, src.Height];
			for (int x = 0; x < src.Width; ++x)
				for (int y = 0; y < src.Height; ++y)
					dest[x, y] = src.GetPixel(x, y).R;
			return dest;
		}

		public static Bitmap ArrToBitmap(int[,] src) {
			var dest = new Bitmap(src.GetLength(0), src.GetLength(1));
			for (int x = 0; x < dest.Width; ++x)
				for (int y = 0; y < dest.Height; ++y){
					var t = src[x, y];
					dest.SetPixel(x, y, Color.FromArgb(t,t,t));
				}
			return dest;
		}

		public static int[,] Dilation(int[,] src, int[,] mask) {
			var W = src.GetLength(0);
			var H = src.GetLength(1);
			var dest = new int[W, H];
			var MW = mask.GetLength(0);
			var MH = mask.GetLength(1);


			return dest;
		}

	}
}
