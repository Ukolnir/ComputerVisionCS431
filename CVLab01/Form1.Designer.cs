﻿namespace CVLab01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.яркостныеПреобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.цветоваяКоррекцияИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.correctionWithBasicColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.correctionGreyWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.functionCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelCorrectionWithBasicColor = new System.Windows.Forms.Panel();
			this.applyCorrectionWithBasicColor = new System.Windows.Forms.Button();
			this.labelCorrectionWithColor5 = new System.Windows.Forms.Label();
			this.labelCorrectionWithColor4 = new System.Windows.Forms.Label();
			this.labelCorrectionWithColor2 = new System.Windows.Forms.Label();
			this.labelCorrectionWithColor3 = new System.Windows.Forms.Label();
			this.labelCorrectionWithColor1 = new System.Windows.Forms.Label();
			this.applyСorrectionGreyWorld = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panelFunctionCorrection = new System.Windows.Forms.Panel();
			this.changeApplyFunctionCorrection1 = new System.Windows.Forms.Button();
			this.gammaCounterFunctionCorrection = new System.Windows.Forms.TextBox();
			this.comboBoxFunctionCorrection = new System.Windows.Forms.ComboBox();
			this.changeApplyFunctionCorrection = new System.Windows.Forms.Button();
			this.applyHistCorrection = new System.Windows.Forms.Button();
			this.chartHistCorrection2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartHistCorrection1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.pictureBoxHistCorrection1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxHistCorrection2 = new System.Windows.Forms.PictureBox();
			this.correctionWithEkvalizationHistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelCorrectionWithBasicColor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelFunctionCorrection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartHistCorrection2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistCorrection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistCorrection1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistCorrection2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.яркостныеПреобразованияToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPictureToolStripMenuItem,
            this.savePictureToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// loadPictureToolStripMenuItem
			// 
			this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
			this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.loadPictureToolStripMenuItem.Text = "Загрузить картинку";
			this.loadPictureToolStripMenuItem.Click += new System.EventHandler(this.loadPictureToolStripMenuItem_Click);
			// 
			// savePictureToolStripMenuItem
			// 
			this.savePictureToolStripMenuItem.Name = "savePictureToolStripMenuItem";
			this.savePictureToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
			this.savePictureToolStripMenuItem.Text = "Сохранить картинку";
			this.savePictureToolStripMenuItem.Click += new System.EventHandler(this.savePictureToolStripMenuItem_Click);
			// 
			// яркостныеПреобразованияToolStripMenuItem
			// 
			this.яркостныеПреобразованияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветоваяКоррекцияИзображенийToolStripMenuItem,
            this.correctionWithEkvalizationHistToolStripMenuItem});
			this.яркостныеПреобразованияToolStripMenuItem.Name = "яркостныеПреобразованияToolStripMenuItem";
			this.яркостныеПреобразованияToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
			this.яркостныеПреобразованияToolStripMenuItem.Text = "Яркостные преобразования";
			// 
			// цветоваяКоррекцияИзображенийToolStripMenuItem
			// 
			this.цветоваяКоррекцияИзображенийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctionWithBasicColorToolStripMenuItem,
            this.correctionGreyWorldToolStripMenuItem,
            this.functionCorrectionToolStripMenuItem});
			this.цветоваяКоррекцияИзображенийToolStripMenuItem.Name = "цветоваяКоррекцияИзображенийToolStripMenuItem";
			this.цветоваяКоррекцияИзображенийToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.цветоваяКоррекцияИзображенийToolStripMenuItem.Text = "Цветовая коррекция изображений";
			// 
			// correctionWithBasicColorToolStripMenuItem
			// 
			this.correctionWithBasicColorToolStripMenuItem.Enabled = false;
			this.correctionWithBasicColorToolStripMenuItem.Name = "correctionWithBasicColorToolStripMenuItem";
			this.correctionWithBasicColorToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.correctionWithBasicColorToolStripMenuItem.Text = "Коррекция с опорным цветом";
			this.correctionWithBasicColorToolStripMenuItem.Click += new System.EventHandler(this.correctionWithBasicColorToolStripMenuItem_Click);
			// 
			// correctionGreyWorldToolStripMenuItem
			// 
			this.correctionGreyWorldToolStripMenuItem.Name = "correctionGreyWorldToolStripMenuItem";
			this.correctionGreyWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.correctionGreyWorldToolStripMenuItem.Text = "Серый мир";
			this.correctionGreyWorldToolStripMenuItem.Click += new System.EventHandler(this.correctionGreyWorldToolStripMenuItem_Click);
			// 
			// functionCorrectionToolStripMenuItem
			// 
			this.functionCorrectionToolStripMenuItem.Name = "functionCorrectionToolStripMenuItem";
			this.functionCorrectionToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
			this.functionCorrectionToolStripMenuItem.Text = "По виду функции преобразования";
			this.functionCorrectionToolStripMenuItem.Click += new System.EventHandler(this.functionCorrectionToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(2, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(600, 350);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
			// 
			// panelCorrectionWithBasicColor
			// 
			this.panelCorrectionWithBasicColor.Controls.Add(this.applyCorrectionWithBasicColor);
			this.panelCorrectionWithBasicColor.Controls.Add(this.labelCorrectionWithColor5);
			this.panelCorrectionWithBasicColor.Controls.Add(this.labelCorrectionWithColor4);
			this.panelCorrectionWithBasicColor.Controls.Add(this.labelCorrectionWithColor2);
			this.panelCorrectionWithBasicColor.Controls.Add(this.labelCorrectionWithColor3);
			this.panelCorrectionWithBasicColor.Controls.Add(this.labelCorrectionWithColor1);
			this.panelCorrectionWithBasicColor.Location = new System.Drawing.Point(811, 27);
			this.panelCorrectionWithBasicColor.Name = "panelCorrectionWithBasicColor";
			this.panelCorrectionWithBasicColor.Size = new System.Drawing.Size(466, 646);
			this.panelCorrectionWithBasicColor.TabIndex = 2;
			// 
			// applyCorrectionWithBasicColor
			// 
			this.applyCorrectionWithBasicColor.Location = new System.Drawing.Point(126, 225);
			this.applyCorrectionWithBasicColor.Name = "applyCorrectionWithBasicColor";
			this.applyCorrectionWithBasicColor.Size = new System.Drawing.Size(149, 56);
			this.applyCorrectionWithBasicColor.TabIndex = 5;
			this.applyCorrectionWithBasicColor.Text = "Преобразовать";
			this.applyCorrectionWithBasicColor.UseVisualStyleBackColor = true;
			this.applyCorrectionWithBasicColor.Click += new System.EventHandler(this.applyCorrectionWithBasicColor_Click);
			// 
			// labelCorrectionWithColor5
			// 
			this.labelCorrectionWithColor5.AutoSize = true;
			this.labelCorrectionWithColor5.Location = new System.Drawing.Point(195, 138);
			this.labelCorrectionWithColor5.Name = "labelCorrectionWithColor5";
			this.labelCorrectionWithColor5.Size = new System.Drawing.Size(0, 13);
			this.labelCorrectionWithColor5.TabIndex = 4;
			// 
			// labelCorrectionWithColor4
			// 
			this.labelCorrectionWithColor4.AutoSize = true;
			this.labelCorrectionWithColor4.Location = new System.Drawing.Point(26, 141);
			this.labelCorrectionWithColor4.Name = "labelCorrectionWithColor4";
			this.labelCorrectionWithColor4.Size = new System.Drawing.Size(135, 13);
			this.labelCorrectionWithColor4.TabIndex = 3;
			this.labelCorrectionWithColor4.Text = "Цвет выбраного пикселя";
			// 
			// labelCorrectionWithColor2
			// 
			this.labelCorrectionWithColor2.AutoSize = true;
			this.labelCorrectionWithColor2.Location = new System.Drawing.Point(26, 89);
			this.labelCorrectionWithColor2.Name = "labelCorrectionWithColor2";
			this.labelCorrectionWithColor2.Size = new System.Drawing.Size(128, 13);
			this.labelCorrectionWithColor2.TabIndex = 2;
			this.labelCorrectionWithColor2.Text = "Цвет текущего пикселя";
			// 
			// labelCorrectionWithColor3
			// 
			this.labelCorrectionWithColor3.AutoSize = true;
			this.labelCorrectionWithColor3.Location = new System.Drawing.Point(195, 89);
			this.labelCorrectionWithColor3.Name = "labelCorrectionWithColor3";
			this.labelCorrectionWithColor3.Size = new System.Drawing.Size(0, 13);
			this.labelCorrectionWithColor3.TabIndex = 1;
			// 
			// labelCorrectionWithColor1
			// 
			this.labelCorrectionWithColor1.AutoSize = true;
			this.labelCorrectionWithColor1.Location = new System.Drawing.Point(44, 32);
			this.labelCorrectionWithColor1.Name = "labelCorrectionWithColor1";
			this.labelCorrectionWithColor1.Size = new System.Drawing.Size(327, 13);
			this.labelCorrectionWithColor1.TabIndex = 0;
			this.labelCorrectionWithColor1.Text = "Тыкните на пиксель картинки, цвет которого хотите изменить";
			// 
			// applyСorrectionGreyWorld
			// 
			this.applyСorrectionGreyWorld.Location = new System.Drawing.Point(727, 341);
			this.applyСorrectionGreyWorld.Name = "applyСorrectionGreyWorld";
			this.applyСorrectionGreyWorld.Size = new System.Drawing.Size(254, 81);
			this.applyСorrectionGreyWorld.TabIndex = 6;
			this.applyСorrectionGreyWorld.Text = "Преобразовать";
			this.applyСorrectionGreyWorld.UseVisualStyleBackColor = true;
			this.applyСorrectionGreyWorld.Visible = false;
			this.applyСorrectionGreyWorld.Click += new System.EventHandler(this.applyСorrectionGreyWorld_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(2, 407);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(600, 350);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(565, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "CorrectionWithBasicColor";
			// 
			// colorDialog1
			// 
			this.colorDialog1.FullOpen = true;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "\".jpg\"";
			this.saveFileDialog1.Filter = "\"Image Files(*.BMP;*.JPG;**.PNG)|*.BMP;*.JPG;**.PNG|All files (*.*)|*.*\"";
			this.saveFileDialog1.Title = "Сохранить рисунок как";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Title = "Выберите рисунок";
			// 
			// panelFunctionCorrection
			// 
			this.panelFunctionCorrection.Controls.Add(this.changeApplyFunctionCorrection1);
			this.panelFunctionCorrection.Controls.Add(this.gammaCounterFunctionCorrection);
			this.panelFunctionCorrection.Controls.Add(this.comboBoxFunctionCorrection);
			this.panelFunctionCorrection.Controls.Add(this.changeApplyFunctionCorrection);
			this.panelFunctionCorrection.Controls.Add(this.applyHistCorrection);
			this.panelFunctionCorrection.Controls.Add(this.chartHistCorrection2);
			this.panelFunctionCorrection.Controls.Add(this.chartHistCorrection1);
			this.panelFunctionCorrection.Controls.Add(this.pictureBoxHistCorrection1);
			this.panelFunctionCorrection.Controls.Add(this.pictureBoxHistCorrection2);
			this.panelFunctionCorrection.Location = new System.Drawing.Point(608, 31);
			this.panelFunctionCorrection.Name = "panelFunctionCorrection";
			this.panelFunctionCorrection.Size = new System.Drawing.Size(668, 726);
			this.panelFunctionCorrection.TabIndex = 7;
			this.panelFunctionCorrection.Visible = false;
			// 
			// changeApplyFunctionCorrection1
			// 
			this.changeApplyFunctionCorrection1.Location = new System.Drawing.Point(3, 403);
			this.changeApplyFunctionCorrection1.Name = "changeApplyFunctionCorrection1";
			this.changeApplyFunctionCorrection1.Size = new System.Drawing.Size(25, 47);
			this.changeApplyFunctionCorrection1.TabIndex = 8;
			this.changeApplyFunctionCorrection1.Text = "->";
			this.changeApplyFunctionCorrection1.UseVisualStyleBackColor = true;
			this.changeApplyFunctionCorrection1.Click += new System.EventHandler(this.changeApplyFunctionCorrection1_Click);
			// 
			// gammaCounterFunctionCorrection
			// 
			this.gammaCounterFunctionCorrection.Location = new System.Drawing.Point(497, 325);
			this.gammaCounterFunctionCorrection.Name = "gammaCounterFunctionCorrection";
			this.gammaCounterFunctionCorrection.Size = new System.Drawing.Size(54, 20);
			this.gammaCounterFunctionCorrection.TabIndex = 7;
			this.gammaCounterFunctionCorrection.Text = "1,0";
			this.gammaCounterFunctionCorrection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.gammaCounterFunctionCorrection.Visible = false;
			// 
			// comboBoxFunctionCorrection
			// 
			this.comboBoxFunctionCorrection.FormattingEnabled = true;
			this.comboBoxFunctionCorrection.Items.AddRange(new object[] {
            "Линейная коррекция",
            "Гамма-коррекция"});
			this.comboBoxFunctionCorrection.Location = new System.Drawing.Point(203, 325);
			this.comboBoxFunctionCorrection.Name = "comboBoxFunctionCorrection";
			this.comboBoxFunctionCorrection.Size = new System.Drawing.Size(254, 21);
			this.comboBoxFunctionCorrection.TabIndex = 6;
			this.comboBoxFunctionCorrection.Text = "Линейная коррекция";
			this.comboBoxFunctionCorrection.SelectedValueChanged += new System.EventHandler(this.comboBoxFunctionCorrection_SelectedValueChanged);
			// 
			// changeApplyFunctionCorrection
			// 
			this.changeApplyFunctionCorrection.Location = new System.Drawing.Point(3, 295);
			this.changeApplyFunctionCorrection.Name = "changeApplyFunctionCorrection";
			this.changeApplyFunctionCorrection.Size = new System.Drawing.Size(25, 47);
			this.changeApplyFunctionCorrection.TabIndex = 5;
			this.changeApplyFunctionCorrection.Text = "<-";
			this.changeApplyFunctionCorrection.UseVisualStyleBackColor = true;
			this.changeApplyFunctionCorrection.Click += new System.EventHandler(this.changeApplyFunctionCorrection_Click);
			// 
			// applyHistCorrection
			// 
			this.applyHistCorrection.Location = new System.Drawing.Point(216, 376);
			this.applyHistCorrection.Name = "applyHistCorrection";
			this.applyHistCorrection.Size = new System.Drawing.Size(225, 61);
			this.applyHistCorrection.TabIndex = 4;
			this.applyHistCorrection.Text = "Преобразовать";
			this.applyHistCorrection.UseVisualStyleBackColor = true;
			this.applyHistCorrection.Click += new System.EventHandler(this.applyFunctionCorrection_Click);
			// 
			// chartHistCorrection2
			// 
			chartArea5.Name = "ChartArea1";
			this.chartHistCorrection2.ChartAreas.Add(chartArea5);
			legend5.Name = "Legend1";
			this.chartHistCorrection2.Legends.Add(legend5);
			this.chartHistCorrection2.Location = new System.Drawing.Point(329, 456);
			this.chartHistCorrection2.Name = "chartHistCorrection2";
			this.chartHistCorrection2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chartHistCorrection2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
			series5.ChartArea = "ChartArea1";
			series5.IsVisibleInLegend = false;
			series5.Legend = "Legend1";
			series5.Name = "Img";
			this.chartHistCorrection2.Series.Add(series5);
			this.chartHistCorrection2.Size = new System.Drawing.Size(328, 261);
			this.chartHistCorrection2.TabIndex = 3;
			this.chartHistCorrection2.Text = "chart2";
			this.chartHistCorrection2.Visible = false;
			// 
			// chartHistCorrection1
			// 
			chartArea6.Name = "ChartArea1";
			this.chartHistCorrection1.ChartAreas.Add(chartArea6);
			legend6.Name = "Legend1";
			this.chartHistCorrection1.Legends.Add(legend6);
			this.chartHistCorrection1.Location = new System.Drawing.Point(329, 28);
			this.chartHistCorrection1.Name = "chartHistCorrection1";
			this.chartHistCorrection1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chartHistCorrection1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
			series6.ChartArea = "ChartArea1";
			series6.IsVisibleInLegend = false;
			series6.Legend = "Legend1";
			series6.LegendText = "Before";
			series6.Name = "Img";
			this.chartHistCorrection1.Series.Add(series6);
			this.chartHistCorrection1.Size = new System.Drawing.Size(328, 261);
			this.chartHistCorrection1.TabIndex = 2;
			this.chartHistCorrection1.Text = "chart1";
			this.chartHistCorrection1.Visible = false;
			// 
			// pictureBoxHistCorrection1
			// 
			this.pictureBoxHistCorrection1.Location = new System.Drawing.Point(26, 28);
			this.pictureBoxHistCorrection1.Name = "pictureBoxHistCorrection1";
			this.pictureBoxHistCorrection1.Size = new System.Drawing.Size(289, 261);
			this.pictureBoxHistCorrection1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxHistCorrection1.TabIndex = 1;
			this.pictureBoxHistCorrection1.TabStop = false;
			// 
			// pictureBoxHistCorrection2
			// 
			this.pictureBoxHistCorrection2.Location = new System.Drawing.Point(26, 456);
			this.pictureBoxHistCorrection2.Name = "pictureBoxHistCorrection2";
			this.pictureBoxHistCorrection2.Size = new System.Drawing.Size(289, 261);
			this.pictureBoxHistCorrection2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxHistCorrection2.TabIndex = 0;
			this.pictureBoxHistCorrection2.TabStop = false;
			// 
			// correctionWithEkvalizationHistToolStripMenuItem
			// 
			this.correctionWithEkvalizationHistToolStripMenuItem.Name = "correctionWithEkvalizationHistToolStripMenuItem";
			this.correctionWithEkvalizationHistToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
			this.correctionWithEkvalizationHistToolStripMenuItem.Text = "Эквализация гистограммы";
			this.correctionWithEkvalizationHistToolStripMenuItem.Click += new System.EventHandler(this.correctionWithEkvalizationHistToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1268, 760);
			this.Controls.Add(this.panelFunctionCorrection);
			this.Controls.Add(this.applyСorrectionGreyWorld);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panelCorrectionWithBasicColor);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Обработка изображений";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelCorrectionWithBasicColor.ResumeLayout(false);
			this.panelCorrectionWithBasicColor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelFunctionCorrection.ResumeLayout(false);
			this.panelFunctionCorrection.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartHistCorrection2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHistCorrection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistCorrection1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistCorrection2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePictureToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCorrectionWithBasicColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem яркостныеПреобразованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветоваяКоррекцияИзображенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionWithBasicColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionGreyWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionWithNormalizedHistToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCorrectionWithColor1;
        private System.Windows.Forms.Label labelCorrectionWithColor3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelCorrectionWithColor5;
        private System.Windows.Forms.Label labelCorrectionWithColor4;
        private System.Windows.Forms.Label labelCorrectionWithColor2;
        private System.Windows.Forms.Button applyCorrectionWithBasicColor;
        private System.Windows.Forms.Button applyСorrectionGreyWorld;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelFunctionCorrection;
        private System.Windows.Forms.Button applyHistCorrection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistCorrection2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistCorrection1;
        private System.Windows.Forms.PictureBox pictureBoxHistCorrection1;
        private System.Windows.Forms.PictureBox pictureBoxHistCorrection2;
        private System.Windows.Forms.Button changeApplyFunctionCorrection;
        private System.Windows.Forms.ComboBox comboBoxFunctionCorrection;
        private System.Windows.Forms.TextBox gammaCounterFunctionCorrection;
        private System.Windows.Forms.Button changeApplyFunctionCorrection1;
		private System.Windows.Forms.ToolStripMenuItem correctionWithEkvalizationHistToolStripMenuItem;
	}
}

