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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостныеПреобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветоваяКоррекцияИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionWithBasicColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВидуФункцииПреобразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияНаОсновеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нормализацияГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эквализацияГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCorrectionWithColor3 = new System.Windows.Forms.Label();
            this.labelCorrectionWithColor1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelCorrectionWithColor2 = new System.Windows.Forms.Label();
            this.labelCorrectionWithColor4 = new System.Windows.Forms.Label();
            this.labelCorrectionWithColor5 = new System.Windows.Forms.Label();
            this.apply = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.серыйМирToolStripMenuItem,
            this.поВидуФункцииПреобразованияToolStripMenuItem});
            this.цветоваяКоррекцияИзображенийToolStripMenuItem.Name = "цветоваяКоррекцияИзображенийToolStripMenuItem";
            this.цветоваяКоррекцияИзображенийToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.цветоваяКоррекцияИзображенийToolStripMenuItem.Text = "Цветовая коррекция изображений";
            // 
            // correctionWithBasicColorToolStripMenuItem
            // 
            this.correctionWithBasicColorToolStripMenuItem.Name = "correctionWithBasicColorToolStripMenuItem";
            this.correctionWithBasicColorToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.correctionWithBasicColorToolStripMenuItem.Text = "Коррекция с опорным цветом";
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            // 
            // поВидуФункцииПреобразованияToolStripMenuItem
            // 
            this.поВидуФункцииПреобразованияToolStripMenuItem.Name = "поВидуФункцииПреобразованияToolStripMenuItem";
            this.поВидуФункцииПреобразованияToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.поВидуФункцииПреобразованияToolStripMenuItem.Text = "По виду функции преобразования";
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 330);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.apply);
            this.panel1.Controls.Add(this.labelCorrectionWithColor5);
            this.panel1.Controls.Add(this.labelCorrectionWithColor4);
            this.panel1.Controls.Add(this.labelCorrectionWithColor2);
            this.panel1.Controls.Add(this.labelCorrectionWithColor3);
            this.panel1.Controls.Add(this.labelCorrectionWithColor1);
            this.panel1.Location = new System.Drawing.Point(539, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 646);
            this.panel1.TabIndex = 2;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 330);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CurrentTypeCorrection";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
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
            // labelCorrectionWithColor4
            // 
            this.labelCorrectionWithColor4.AutoSize = true;
            this.labelCorrectionWithColor4.Location = new System.Drawing.Point(26, 141);
            this.labelCorrectionWithColor4.Name = "labelCorrectionWithColor4";
            this.labelCorrectionWithColor4.Size = new System.Drawing.Size(135, 13);
            this.labelCorrectionWithColor4.TabIndex = 3;
            this.labelCorrectionWithColor4.Text = "Цвет выбраного пикселя";
            // 
            // labelCorrectionWithColor5
            // 
            this.labelCorrectionWithColor5.AutoSize = true;
            this.labelCorrectionWithColor5.Location = new System.Drawing.Point(195, 138);
            this.labelCorrectionWithColor5.Name = "labelCorrectionWithColor5";
            this.labelCorrectionWithColor5.Size = new System.Drawing.Size(0, 13);
            this.labelCorrectionWithColor5.TabIndex = 4;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(126, 225);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(149, 56);
            this.apply.TabIndex = 5;
            this.apply.Text = "Преобразовать";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePictureToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem яркостныеПреобразованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветоваяКоррекцияИзображенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionWithBasicColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВидуФункцииПреобразованияToolStripMenuItem;
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
        private System.Windows.Forms.Button apply;
    }
}

