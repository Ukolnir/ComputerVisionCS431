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
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
        }

        private void button1_Click(object sender, EventArgs e){
            //Работает пока только для двух уровней квантования
            pictureBox2.Image = Transformations.QuantizationImage(sourceFile,intensity,2);
            //pictureBox2.Image = Transformations.QuantizationImage(sourceFile, intensity, (int)numericUpDown1.Value);
        }
    }
}