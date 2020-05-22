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
		readonly NegativeBinomial NB;
		public Form1()
		{
			InitializeComponent();
			NB = new NegativeBinomial();
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			NB.Start(param1Value.Value, (int)numberValue.Value);

			chart1.Series[0].Points.Clear();
			for (int i = 0; i < NB.Probabilities.Length; i++)
			{
				chart1.Series[0].Points.AddXY(i, NB.Probabilities[i]);
			}

			average.Text = NB.Average.ToString("F3") + " (error = " + decimal.Round(NB.AverageError * 100) + "%)";
			variance.Text = NB.Variance.ToString("F3") + " (error = " + decimal.Round(NB.VarianceError * 100) + "%)";

			chiSquared.Text = NB.ChiSquare.ToString("F3") + " <= " + NB.CriticalValue.ToString("F3") + " is ";

			if (NB.ChiSquareTest)
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
