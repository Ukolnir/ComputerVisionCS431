using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVLab01
{
    public enum TransformType { CorrectionWithBasicColor = 1 }

    public partial class Form1 : Form
    {
        TransformType currentType;
        public Form1()
        {
            InitializeComponent();
            currentType = TransformType.CorrectionWithBasicColor;
        }

        Bitmap sourceFile;
        Color pixelColorSource;
        Color pixelColorDestination;

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                sourceFile = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = sourceFile;
                correction1 = new CorrectionWithBasicColor(sourceFile);
            }
                
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image!= null && currentType == TransformType.CorrectionWithBasicColor) {
                pixelColorSource = ((Bitmap)pictureBox1.Image).GetPixel(e.X, e.Y);
                labelCorrectionWithColor3.Text = "R " + pixelColorSource.R 
                    + " G " + pixelColorSource.G 
                    + " B " + pixelColorSource.B;
                colorDialog1.Color = pixelColorSource;
                correction1.ColorSource = pixelColorSource;
                if (colorDialog1.ShowDialog() == DialogResult.OK) {
                    pixelColorDestination = colorDialog1.Color;
                    labelCorrectionWithColor5.Text = "R " + pixelColorDestination.R 
                        + " G " + pixelColorDestination.G 
                        + " B " + pixelColorDestination.B;
                    correction1.ColorDestination = pixelColorDestination;
                }
            }
        }

        private void apply_Click(object sender, EventArgs e){
            pictureBox2.Image = correction1.Transform();
            pictureBox2.Update();
        }






        //-----------
        CorrectionWithBasicColor correction1;
    }
}
