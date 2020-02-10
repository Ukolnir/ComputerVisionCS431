using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVLab1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bitmap imgFile;
			List<int> red = new List<int>();
			List<int> green = new List<int>();
			List<int> blue = new List<int>();
			for (int i = 0; i < 256; ++i) {
				red.Add(0);
				green.Add(0);
				blue.Add(0);
			}

			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				imgFile = new Bitmap(openFileDialog.FileName);
				pictureBox1.Image = imgFile;
				for (int i = 0; i < imgFile.Width; ++i)
					for (int j = 0; j < imgFile.Height; ++j) {
						Color t = imgFile.GetPixel(i, j);
						++red[t.R];
						++green[t.G];
						++blue[t.B];
					}

				chart1.Series["Series1"].Points.Clear();
				chart2.Series["Series1"].Points.Clear();
				chart3.Series["Series1"].Points.Clear();

				for (int i = 0; i < 256; ++i) {
					chart1.Series["Series1"].Points.AddY(red[i]);
					chart1.Series["Series1"].Points[i].Color = Color.Red;
					chart2.Series["Series1"].Points.AddY(green[i]);
					chart2.Series["Series1"].Points[i].Color = Color.Green;
					chart3.Series["Series1"].Points.AddY(blue[i]);
					chart3.Series["Series1"].Points[i].Color = Color.Blue;
				}

				chart1.Update();
				chart2.Update();
				chart3.Update();

			}

		}
	}
}
