using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CVLab03
{
	public partial class Form1 : Form
	{
		public Form1(){
			InitializeComponent();
		}

        Bitmap sourceFile;

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e){
			if (openFileDialog1.ShowDialog() == DialogResult.OK){
                sourceFile = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = sourceFile;
			}
		}

		private void savePictureToolStripMenuItem_Click(object sender, EventArgs e){
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
		}

        List<string> maskNames;

        private void loadMaskToolStripMenuItem_Click(object sender, EventArgs e){
            maskNames = new List<string>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                maskNames = openFileDialog1.FileNames.ToList();
        }

        private void button3_Click(object sender, EventArgs e){
            var b = Operations.BitmapToArr(sourceFile);
            var b1 = Operations.Erode(b,
                    Operations.BitmapToArr(new Bitmap(maskNames[0])));

            var b2 = Operations.Dilate(b1,
                    Operations.BitmapToArr(new Bitmap(maskNames[1])));

            var b3 = Operations.Or(b, b2);

            /*var b4 = Operations.Opening(b3,
                Operations.BitmapToArr(new Bitmap(maskNames[2])));

            var b5 = Operations.Dilate(b4,
                    Operations.BitmapToArr(new Bitmap(maskNames[3])));

            var b6 = Operations.Dilate(b5,
                    Operations.BitmapToArr(new Bitmap(maskNames[4])));

            var b7 = Operations.Difference(b6, b5);

            var b8 = Operations.And(b, b7);

            var b9 = Operations.Dilate(b8,
                   Operations.BitmapToArr(new Bitmap(maskNames[5])));

            var b100 = Operations.Difference(b7, b9);
            var b101 = Operations.Dilate(b100,
                   Operations.BitmapToArr(new Bitmap(maskNames[6])));
            var b10 = Operations.Or(b101,b9);*/
            pictureBox2.Image = Operations.ArrToBitmap(b3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = Operations.BitmapToArr(sourceFile);
            var b1 = Operations.Erode(b,
                    Operations.BitmapToArr(new Bitmap(maskNames[0])));
            pictureBox2.Image = Operations.ArrToBitmap(b1);
        }

        /*
        1. Эрозия с маской-кольцо +
        2. Дилатация с маской-кружком +
        3. Исходное ИЛИ (2) +
        4. Размыкание маской-диском с радиусом == шестеренке - высота зубца
        5. Дилатация с маской-sampling-ring-spacer ????
        6. Дилатация с маской-sampling-ring-width ???
        7. (6) - (5)
        8. Исходное И (7)
        9. Дилатация с маской-немного расширение полосы
        10. (Дилатация ((7) - (9)) с маской-кружком для дефектов) ИЛИ (9)
         */
    }
}