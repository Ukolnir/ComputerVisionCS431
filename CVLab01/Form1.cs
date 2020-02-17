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
    public enum TransformType { CorrectionWithBasicColor = 1, CorrectionGreyWorld, FunctionCorrection,
        CorrectionWithEqualizationHist }

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
        CorrectionWithEqualizationHist correction4;

        //-------------------

        private void loadPictureToolStripMenuItem_Click(object sender, EventArgs e){
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                sourceFile = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = sourceFile;
                correction1 = new CorrectionWithBasicColor(sourceFile);
                correction2 = new CorrectionGreyWorld(sourceFile);
                correction3 = new FunctionCorrection(sourceFile);
                correction4 = new CorrectionWithEqualizationHist(sourceFile);
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
                    chartHistCorrection1.Visible = false;
                    chartHistCorrection2.Visible = false;
                    
                    break;
                case TransformType.CorrectionWithEqualizationHist:
					correctionWithEkvalizationHistToolStripMenuItem.Enabled = true;
                    panelFunctionCorrection.Visible = false;
                    chartHistCorrection1.Visible = false;
                    chartHistCorrection2.Visible = false;
                    break;
            }
            pictureBox2.Image = null;
			pictureBoxHistCorrection2.Image = null;
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
            comboBoxFunctionCorrection.Visible = true;
            //------------

            if (pictureBox1.Image != null)
                makeGreyAndHist(correction3);
        }

        private void makeGreyAndHist(HistCorrection cor) {
            pictureBoxHistCorrection1.Image = cor.RGBtoGrey();
            chartHistCorrection1.Visible = true;
            chartHistCorrection1.Series["Img"].Points.Clear();
            for (int i = 0; i < 256; ++i)
                chartHistCorrection1.Series["Img"].Points.AddY(cor.IntensitySource[i]);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e){
            switch (currentType) {
                case TransformType.FunctionCorrection:
                    makeGreyAndHist(correction3);
                    break;
                case TransformType.CorrectionWithEqualizationHist:
                    makeGreyAndHist(correction4);
                    break;
            }    
        }

        private void applyFunctionCorrection_Click(object sender, EventArgs e){
            if (currentType == TransformType.FunctionCorrection){
                switch ((string)comboBoxFunctionCorrection.SelectedItem){
                    case "Линейная коррекция":
                        var mm = correction3.getMinMaxIntens();
                        pictureBoxHistCorrection2.Image = 
                            correction3.TransformWithLinearCorrection(mm.Item1, mm.Item2);
                        break;
                    case "Гамма-коррекция":
                        pictureBoxHistCorrection2.Image =
                            correction3.TransformWithGammaCorrection(Double.Parse(gammaCounterFunctionCorrection.Text));
                        break;
                }
                fillHistAfterTransfrom(correction3);
            }
            else {
                pictureBoxHistCorrection2.Image = correction4.Transform();
                fillHistAfterTransfrom(correction4);
            }
        }

        private void fillHistAfterTransfrom(HistCorrection cor) {
            chartHistCorrection2.Visible = true;
            chartHistCorrection2.Series["Img"].Points.Clear();
            pictureBox2.Image = cor.ColorImage;
            for (int i = 0; i < 256; ++i)
                chartHistCorrection2.Series["Img"].Points.AddY(cor.IntensityAfterTransform[i]);
        }

        private void changeApplyFunctionCorrection_Click(object sender, EventArgs e)
        {
            correction3 = new FunctionCorrection((Bitmap)pictureBox2.Image);
            correction4 = new CorrectionWithEqualizationHist((Bitmap)pictureBox2.Image);
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = null;
            pictureBoxHistCorrection2.Image = null;
            chartHistCorrection2.Visible = false;
        }

        private void comboBoxFunctionCorrection_SelectedValueChanged(object sender, EventArgs e)
        {
            gammaCounterFunctionCorrection.Visible = 
                (string)comboBoxFunctionCorrection.SelectedItem == "Гамма-коррекция";
        }

        private void changeApplyFunctionCorrection1_Click(object sender, EventArgs e){
			if (currentType == TransformType.FunctionCorrection){
				correction3.Clear();
				correction3.RGBtoGrey();
			}
			else {
				correction4.Clear();
				correction4.RGBtoGrey();
			}
            
			pictureBox2.Image = null;
			pictureBoxHistCorrection2.Image = null;
			chartHistCorrection2.Visible = false;
        }

        private void correctionWithEkvalizationHistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeType();
			correctionWithEkvalizationHistToolStripMenuItem.Enabled = false;
            panelFunctionCorrection.Visible = true;
            currentType = TransformType.CorrectionWithEqualizationHist;
            label1.Text = currentType.ToString();
            comboBoxFunctionCorrection.Visible = false;

            if (pictureBox1.Image != null)
                makeGreyAndHist(correction4);
        }
	}
}
