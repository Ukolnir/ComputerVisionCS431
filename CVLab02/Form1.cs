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

namespace CVLab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap sourceFile;
        int[] intensity;

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e){
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                intensity = Transformations.RGBtoGrey(new Bitmap(openFileDialog1.FileName), ref sourceFile);
                pictureBox1.Image = sourceFile;
                chart1.Series["Series1"].Points.Clear();
                for (int i = 0; i < 256; ++i)
                    chart1.Series["Series1"].Points.AddY(intensity[i]);
            }
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e){
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
        }

        private void button1_Click(object sender, EventArgs e){
            pictureBox2.Image = Transformations.QuantizationImage(sourceFile, (int)numericUpDown1.Value);
        }

        private void button2_Click(object sender, EventArgs e){
            pictureBox2.Image = Transformations.Binarization(sourceFile, (int)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e){
            pictureBox2.Image = Transformations.Binarization(sourceFile, (int)numericUpDown2.Value,true);
        }

        private void button4_Click(object sender, EventArgs e){
            pictureBox2.Image = Transformations.BinarizationD(sourceFile, 
                                            (int)numericUpDown2.Value,
                                            (int)numericUpDown3.Value);
        }

        private void button5_Click(object sender, EventArgs e){
            pictureBox2.Image = Transformations.GlobalOtsu(sourceFile, intensity);
        }

        private void button6_Click(object sender, EventArgs e)
        {
			pictureBox2.Image = Transformations.LocalOtsu(sourceFile);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			pictureBox2.Image = Transformations.IerarhOtsu(sourceFile, intensity, (int)numericUpDown4.Value);
		}
	}
}