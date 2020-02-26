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

		private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//допустим, что на входе уже бинаризованное изображение
				sourceFile = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image = sourceFile;
			}
		}

		private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Сделать поэтапное изменение картинки
		}
	}
}