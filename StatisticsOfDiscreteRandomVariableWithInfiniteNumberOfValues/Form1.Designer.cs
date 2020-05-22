namespace StatisticsOfDiscreteRandomVariableWithInfiniteNumberOfValues
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.numberValue = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.param1Value = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label7 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.average = new System.Windows.Forms.Label();
			this.variance = new System.Windows.Forms.Label();
			this.chiSquared = new System.Windows.Forms.Label();
			this.test = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.param1Value)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.startButton);
			this.panel1.Controls.Add(this.numberValue);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.param1Value);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(307, 450);
			this.panel1.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.Location = new System.Drawing.Point(191, 207);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(94, 30);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// numberValue
			// 
			this.numberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberValue.Location = new System.Drawing.Point(191, 175);
			this.numberValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numberValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numberValue.Name = "numberValue";
			this.numberValue.Size = new System.Drawing.Size(94, 26);
			this.numberValue.TabIndex = 1;
			this.numberValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 177);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Number of experiments";
			// 
			// param1Value
			// 
			this.param1Value.DecimalPlaces = 3;
			this.param1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.param1Value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.param1Value.Location = new System.Drawing.Point(86, 127);
			this.param1Value.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.param1Value.Name = "param1Value";
			this.param1Value.Size = new System.Drawing.Size(120, 26);
			this.param1Value.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Param 1";
			// 
			// chart1
			// 
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Location = new System.Drawing.Point(307, 0);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 2;
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(828, 361);
			this.chart1.TabIndex = 1;
			this.chart1.Text = "chart1";
			title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
			title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			title1.Name = "Freq";
			title1.Text = "freq.";
			this.chart1.Titles.Add(title1);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(313, 364);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "Average:";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label.Location = new System.Drawing.Point(313, 384);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(76, 20);
			this.label.TabIndex = 2;
			this.label.Text = "Variance:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(313, 421);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Chi-squared:";
			// 
			// average
			// 
			this.average.AutoSize = true;
			this.average.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.average.Location = new System.Drawing.Point(391, 364);
			this.average.Name = "average";
			this.average.Size = new System.Drawing.Size(0, 20);
			this.average.TabIndex = 2;
			// 
			// variance
			// 
			this.variance.AutoSize = true;
			this.variance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.variance.Location = new System.Drawing.Point(395, 384);
			this.variance.Name = "variance";
			this.variance.Size = new System.Drawing.Size(0, 20);
			this.variance.TabIndex = 2;
			// 
			// chiSquared
			// 
			this.chiSquared.AutoSize = true;
			this.chiSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chiSquared.Location = new System.Drawing.Point(418, 421);
			this.chiSquared.Name = "chiSquared";
			this.chiSquared.Size = new System.Drawing.Size(0, 20);
			this.chiSquared.TabIndex = 2;
			// 
			// test
			// 
			this.test.AutoSize = true;
			this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.test.Location = new System.Drawing.Point(565, 421);
			this.test.Name = "test";
			this.test.Size = new System.Drawing.Size(0, 20);
			this.test.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Geometric Distribution";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 450);
			this.Controls.Add(this.test);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label);
			this.Controls.Add(this.chiSquared);
			this.Controls.Add(this.variance);
			this.Controls.Add(this.average);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Statistics Of Event Generating";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numberValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.param1Value)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.NumericUpDown param1Value;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown numberValue;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label average;
		private System.Windows.Forms.Label variance;
		private System.Windows.Forms.Label chiSquared;
		private System.Windows.Forms.Label test;
		private System.Windows.Forms.Label label2;
	}
}

