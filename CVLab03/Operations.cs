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
					dest[x, y] = src.GetPixel(x, y).R == 0? 0 : 1;
			return dest;
		}

		public static Bitmap ArrToBitmap(int[,] src) {
			var dest = new Bitmap(src.GetLength(0), src.GetLength(1));
			for (int x = 0; x < dest.Width; ++x)
				for (int y = 0; y < dest.Height; ++y){
					var t = src[x, y];
					dest.SetPixel(x, y, Color.FromArgb(t*255,t*255,t*255));
				}
			return dest;
		}

		public static int[,] Dilate(int[,] src, int[,] mask) {
			var W = src.GetLength(0);
			var H = src.GetLength(1);
			var dest = new int[W, H];
			var MW = mask.GetLength(0) / 2;
			var MH = mask.GetLength(1) / 2;
            for (int y = MH; y < H - MH; ++y)
                for (int x = MW; x < W - MW; ++x) {
                    int max = 0;
                    for (int j = -MH; j < MH; ++j)
                        for (int i = -MW; i < MW; ++i)
                            if (mask[i + MW, j + MH] == 1 && src[x + i, y + j] > max)
                                max = src[x + i, y + j];
                    dest[x, y] = max;
                }
			return dest;
		}

        public static int[,] Erode(int[,] src, int[,] mask){
            var W = src.GetLength(0);
            var H = src.GetLength(1);
            var dest = new int[W, H];
            var MW = mask.GetLength(0) / 2;
            var MH = mask.GetLength(1) / 2;
            for (int y = MH; y < H - MH; ++y)
                for (int x = MW; x < W - MW; ++x)
                {
                    int min = Int32.MaxValue;
                    for (int j = -MH; j < MH; ++j)
                        for (int i = -MW; i < MW; ++i)
                            if (mask[i + MW, j + MH] == 1 && src[x + i, y + j] < min)
                                min = src[x + i, y + j];
                    dest[x, y] = min;
                }
            return dest;
        }

        public static int[,] Closing(int[,] src, int[,] mask) {
            return Erode(Dilate(src,mask), mask);
        }

        public static int[,] Opening(int[,] src, int[,] mask){
            return Dilate(Erode(src, mask), mask);
        }

        public static int[,] Or(int[,] first, int[,] second) {
            var W = first.GetLength(0);
            var H = first.GetLength(1);
            var dest = new int[W, H];

            for (int x = 0; x < W; ++x)
                for (int y = 0; y < H; ++y)
                    dest[x, y] = first[x, y] == 1 || second[x, y] == 1 ? 1 : 0;
            return dest;
        }

        public static int[,] And(int[,] first, int[,] second)
        {
            var W = first.GetLength(0);
            var H = first.GetLength(1);
            var dest = new int[W, H];

            for (int x = 0; x < W; ++x)
                for (int y = 0; y < H; ++y)
                    dest[x, y] = first[x, y] == 1 && second[x, y] == 1 ? 1 : 0;
            return dest;
        }

        public static int[,] Difference(int[,] first, int[,] second)
        {
            var W = first.GetLength(0);
            var H = first.GetLength(1);
            var dest = new int[W, H];

            for (int x = 0; x < W; ++x)
                for (int y = 0; y < H; ++y)
                    dest[x, y] = first[x, y] == 1 && second[x, y] == 0 ? 1 : 0;
            return dest;
        }
    }
}
