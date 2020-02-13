namespace CVLab1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(349, 225);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 348);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 59);
			this.button1.TabIndex = 1;
			this.button1.Text = "Загрузить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(417, 22);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(393, 167);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(417, 195);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(393, 155);
			this.chart2.TabIndex = 3;
			this.chart2.Text = "chart2";
			// 
			// chart3
			// 
			chartArea3.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart3.Legends.Add(legend3);
			this.chart3.Location = new System.Drawing.Point(417, 356);
			this.chart3.Name = "chart3";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart3.Series.Add(series3);
			this.chart3.Size = new System.Drawing.Size(393, 164);
			this.chart3.TabIndex = 4;
			this.chart3.Text = "chart3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 576);
			this.Controls.Add(this.chart3);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
	}
}

