namespace CVLab01
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостныеПреобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветоваяКоррекцияИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionWithBasicColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionGreyWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияНаОсновеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормализацияГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализацияГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.applyFunctionCorrection = new System.Windows.Forms.Button();
            this.chartFunctionCorrection2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFunctionCorrection1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBoxFunctionCorrection1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFunctionCorrection2 = new System.Windows.Forms.PictureBox();
            this.changeApplyFunctionCorrection = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCorrectionWithBasicColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFunctionCorrection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionCorrection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionCorrection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunctionCorrection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunctionCorrection2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.яркостныеПреобразованияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
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
            this.коррекцияНаОсновеГистограммыToolStripMenuItem});
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
            // коррекцияНаОсновеГистограммыToolStripMenuItem
            // 
            this.коррекцияНаОсновеГистограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нормализацияГистограммыToolStripMenuItem,
            this.эквализацияГистограммыToolStripMenuItem});
            this.коррекцияНаОсновеГистограммыToolStripMenuItem.Name = "коррекцияНаОсновеГистограммыToolStripMenuItem";
            this.коррекцияНаОсновеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.коррекцияНаОсновеГистограммыToolStripMenuItem.Text = "Коррекция на основе гистограммы";
            // 
            // нормализацияГистограммыToolStripMenuItem
            // 
            this.нормализацияГистограммыToolStripMenuItem.Name = "нормализацияГистограммыToolStripMenuItem";
            this.нормализацияГистограммыToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.нормализацияГистограммыToolStripMenuItem.Text = "Нормализация гистограммы";
            // 
            // эквализацияГистограммыToolStripMenuItem
            // 
            this.эквализацияГистограммыToolStripMenuItem.Name = "эквализацияГистограммыToolStripMenuItem";
            this.эквализацияГистограммыToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.эквализацияГистограммыToolStripMenuItem.Text = "Эквализация гистограммы";
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
            this.saveFileDialog1.Title = "Сохранить рисунок как";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Выберите рисунок";
            // 
            // panelFunctionCorrection
            // 
            this.panelFunctionCorrection.Controls.Add(this.changeApplyFunctionCorrection);
            this.panelFunctionCorrection.Controls.Add(this.applyFunctionCorrection);
            this.panelFunctionCorrection.Controls.Add(this.chartFunctionCorrection2);
            this.panelFunctionCorrection.Controls.Add(this.chartFunctionCorrection1);
            this.panelFunctionCorrection.Controls.Add(this.pictureBoxFunctionCorrection1);
            this.panelFunctionCorrection.Controls.Add(this.pictureBoxFunctionCorrection2);
            this.panelFunctionCorrection.Location = new System.Drawing.Point(608, 31);
            this.panelFunctionCorrection.Name = "panelFunctionCorrection";
            this.panelFunctionCorrection.Size = new System.Drawing.Size(668, 726);
            this.panelFunctionCorrection.TabIndex = 7;
            this.panelFunctionCorrection.Visible = false;
            // 
            // applyFunctionCorrection
            // 
            this.applyFunctionCorrection.Location = new System.Drawing.Point(216, 376);
            this.applyFunctionCorrection.Name = "applyFunctionCorrection";
            this.applyFunctionCorrection.Size = new System.Drawing.Size(225, 61);
            this.applyFunctionCorrection.TabIndex = 4;
            this.applyFunctionCorrection.Text = "Преобразовать";
            this.applyFunctionCorrection.UseVisualStyleBackColor = true;
            this.applyFunctionCorrection.Click += new System.EventHandler(this.applyFunctionCorrection_Click);
            // 
            // chartFunctionCorrection2
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunctionCorrection2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunctionCorrection2.Legends.Add(legend1);
            this.chartFunctionCorrection2.Location = new System.Drawing.Point(329, 456);
            this.chartFunctionCorrection2.Name = "chartFunctionCorrection2";
            this.chartFunctionCorrection2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartFunctionCorrection2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Img";
            this.chartFunctionCorrection2.Series.Add(series1);
            this.chartFunctionCorrection2.Size = new System.Drawing.Size(328, 261);
            this.chartFunctionCorrection2.TabIndex = 3;
            this.chartFunctionCorrection2.Text = "chart2";
            this.chartFunctionCorrection2.Visible = false;
            // 
            // chartFunctionCorrection1
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunctionCorrection1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunctionCorrection1.Legends.Add(legend2);
            this.chartFunctionCorrection1.Location = new System.Drawing.Point(329, 28);
            this.chartFunctionCorrection1.Name = "chartFunctionCorrection1";
            this.chartFunctionCorrection1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartFunctionCorrection1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "Before";
            series2.Name = "Img";
            this.chartFunctionCorrection1.Series.Add(series2);
            this.chartFunctionCorrection1.Size = new System.Drawing.Size(328, 261);
            this.chartFunctionCorrection1.TabIndex = 2;
            this.chartFunctionCorrection1.Text = "chart1";
            this.chartFunctionCorrection1.Visible = false;
            // 
            // pictureBoxFunctionCorrection1
            // 
            this.pictureBoxFunctionCorrection1.Location = new System.Drawing.Point(26, 28);
            this.pictureBoxFunctionCorrection1.Name = "pictureBoxFunctionCorrection1";
            this.pictureBoxFunctionCorrection1.Size = new System.Drawing.Size(289, 261);
            this.pictureBoxFunctionCorrection1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFunctionCorrection1.TabIndex = 1;
            this.pictureBoxFunctionCorrection1.TabStop = false;
            // 
            // pictureBoxFunctionCorrection2
            // 
            this.pictureBoxFunctionCorrection2.Location = new System.Drawing.Point(26, 456);
            this.pictureBoxFunctionCorrection2.Name = "pictureBoxFunctionCorrection2";
            this.pictureBoxFunctionCorrection2.Size = new System.Drawing.Size(289, 261);
            this.pictureBoxFunctionCorrection2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFunctionCorrection2.TabIndex = 0;
            this.pictureBoxFunctionCorrection2.TabStop = false;
            // 
            // changeApplyFunctionCorrection
            // 
            this.changeApplyFunctionCorrection.Location = new System.Drawing.Point(3, 344);
            this.changeApplyFunctionCorrection.Name = "changeApplyFunctionCorrection";
            this.changeApplyFunctionCorrection.Size = new System.Drawing.Size(35, 47);
            this.changeApplyFunctionCorrection.TabIndex = 5;
            this.changeApplyFunctionCorrection.Text = "<->";
            this.changeApplyFunctionCorrection.UseVisualStyleBackColor = true;
            this.changeApplyFunctionCorrection.Click += new System.EventHandler(this.changeApplyFunctionCorrection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 760);
            this.Controls.Add(this.panelFunctionCorrection);
            this.Controls.Add(this.applyСorrectionGreyWorld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelCorrectionWithBasicColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCorrectionWithBasicColor.ResumeLayout(false);
            this.panelCorrectionWithBasicColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFunctionCorrection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionCorrection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctionCorrection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunctionCorrection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunctionCorrection2)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem коррекцияНаОсновеГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нормализацияГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эквализацияГистограммыToolStripMenuItem;
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
        private System.Windows.Forms.Button applyFunctionCorrection;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionCorrection2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctionCorrection1;
        private System.Windows.Forms.PictureBox pictureBoxFunctionCorrection1;
        private System.Windows.Forms.PictureBox pictureBoxFunctionCorrection2;
        private System.Windows.Forms.Button changeApplyFunctionCorrection;
    }
}

