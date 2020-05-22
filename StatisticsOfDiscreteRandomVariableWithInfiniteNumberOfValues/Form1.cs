using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsOfDiscreteRandomVariableWithInfiniteNumberOfValues
{
	public partial class Form1 : Form
	{
		readonly GeometricDistribution distribution;
		public Form1()
		{
			InitializeComponent();
			distribution = new GeometricDistribution();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			distribution.Start(param1Value.Value, (int)numberValue.Value);

			chart1.Series[0].Points.Clear();
			for (int i = 0; i < distribution.Probabilities.Length; i++)
			{
				chart1.Series[0].Points.AddXY(i, distribution.Probabilities[i]);
			}

			average.Text = distribution.Average.ToString("F3") + " (error = " + decimal.Round(distribution.AverageError * 100) + "%)";
			variance.Text = distribution.Variance.ToString("F3") + " (error = " + decimal.Round(distribution.VarianceError * 100) + "%)";

			chiSquared.Text = distribution.ChiSquare.ToString("F3") + " <= " + distribution.CriticalValue.ToString("F3") + " is ";

			if (distribution.ChiSquareTest)
			{
				test.Text = "true";
				test.ForeColor = Color.Green;
			}
			else
			{
				test.Text = "false";
				test.ForeColor = Color.Red;
			}
		}
	}
}
