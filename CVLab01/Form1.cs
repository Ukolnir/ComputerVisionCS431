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

namespace CVLab01
{
    public enum TransformType { CorrectionWithBasicColor = 1, CorrectionGreyWorld, FunctionCorrection }

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

        //-----------
        CorrectionWithBasicColor correction1;
        CorrectionGreyWorld correction2;
        FunctionCorrection correction3;


        //-------------------

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e){
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                sourceFile = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = sourceFile;
                correction1 = new CorrectionWithBasicColor(sourceFile);
                correction2 = new CorrectionGreyWorld(sourceFile);
                correction3 = new FunctionCorrection(sourceFile);
            }  
        }

        private void savePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e){
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

        private void applyCorrectionWithBasicColor_Click(object sender, EventArgs e){
            pictureBox2.Image = correction1.Transform();
            pictureBox2.Update();
        }

        private void correctionWithBasicColorToolStripMenuItem_Click(object sender, EventArgs e){
            changeType();
            correctionWithBasicColorToolStripMenuItem.Enabled = false;
            panelCorrectionWithBasicColor.Visible = true;
            currentType = TransformType.CorrectionWithBasicColor;
            label1.Text = currentType.ToString();
        }

        private void changeType(){
            switch (currentType){
                case TransformType.CorrectionWithBasicColor:
                    correctionWithBasicColorToolStripMenuItem.Enabled = true;
                    panelCorrectionWithBasicColor.Visible = false;
                    break;

                case TransformType.CorrectionGreyWorld:
                    correctionGreyWorldToolStripMenuItem.Enabled = true;
                    applyСorrectionGreyWorld.Visible = false;
                    break;

                case TransformType.FunctionCorrection:
                    functionCorrectionToolStripMenuItem.Enabled = true;
                    panelFunctionCorrection.Visible = false;
                    chartFunctionCorrection1.Visible = false;
                    chartFunctionCorrection2.Visible = false;
                    break;
            }
            pictureBox2.Image = null;
        }

        private void correctionGreyWorldToolStripMenuItem_Click(object sender, EventArgs e){
            changeType();
            correctionGreyWorldToolStripMenuItem.Enabled = false;
            applyСorrectionGreyWorld.Visible = true;
            currentType = TransformType.CorrectionGreyWorld;
            label1.Text = currentType.ToString();
        }

        private void applyСorrectionGreyWorld_Click(object sender, EventArgs e){
            pictureBox2.Image = correction2.Transform();
            pictureBox2.Update();
        }

        private void functionCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeType();
            functionCorrectionToolStripMenuItem.Enabled = false;
            panelFunctionCorrection.Visible = true;
            currentType = TransformType.FunctionCorrection;
            label1.Text = currentType.ToString();

            //------------

            if (pictureBox1.Image != null)
                makeGreyAndHist();
        }

        private void makeGreyAndHist() {
            pictureBoxFunctionCorrection1.Image = correction3.RGBtoGrey();
            chartFunctionCorrection1.Visible = true;
            chartFunctionCorrection1.Series["Img"].Points.Clear();
            for (int i = 0; i < 256; ++i)
                chartFunctionCorrection1.Series["Img"].Points.AddY(correction3.IntensitySource[i]);
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (currentType == TransformType.FunctionCorrection){
                makeGreyAndHist();
            }
        }

        private void applyFunctionCorrection_Click(object sender, EventArgs e){
            //pictureBox2.Image = correction3.TransformWithLinearLightCorrection();
            //pictureBox2.Update();
            pictureBoxFunctionCorrection2.Image = correction3.TransformWithLinearLightCorrection();
            pictureBox2.Image = correction3.ColorImage; //_--------------------------
            chartFunctionCorrection2.Visible = true;
            chartFunctionCorrection2.Series["Img"].Points.Clear();
            for (int i = 0; i < 256; ++i)
                chartFunctionCorrection2.Series["Img"].Points.AddY(correction3.IntensityAfterTransform[i]);
        }

        private void changeApplyFunctionCorrection_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = null;
            pictureBoxFunctionCorrection2.Image = null;
            chartFunctionCorrection2.Visible = false;
        }
    }
}
