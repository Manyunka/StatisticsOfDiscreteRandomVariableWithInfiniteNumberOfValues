using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace StatisticsOfDiscreteRandomVariableWithInfiniteNumberOfValues
{
	public class NegativeBinomial
	{
		const int m = 10;
		Random random = new Random();

		public decimal Average { get; private set; }
		public decimal AverageError { get; private set; }
		public decimal Variance { get; private set; }
		public decimal VarianceError { get; private set; }

		public decimal ChiSquare { get; private set; }
		public bool ChiSquareTest { get; private set; }
		public decimal CriticalValue { get; private set; }

		public decimal[] Probabilities { get; private set; }


		public void Start(decimal p, int n)
		{
			var frequency = Generator(p, n);
			Probabilities = EmpiricalProbs(frequency, n);
			var tProbs = TheoreticalProbs(p, Probabilities.Length);

			Average = 0;
			decimal E = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				Average += Probabilities[i] * i;
				E += tProbs[i] * i;
			}
			AverageError = Math.Abs((Average - E) / E);

			Variance = 0;
			decimal D = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				Variance += Probabilities[i] * i * i;
				D += tProbs[i] * i * i;
			}
			Variance -= Average * Average;
			D -= E * E;
			VarianceError = Math.Abs((Variance - D) / D);

			ChiSquare = 0;
			for (int i = 0; i < Probabilities.Length; i++)
			{
				ChiSquare += (frequency[i] - n * tProbs[i]) * (frequency[i] - n * tProbs[i]) / (n * tProbs[i]);
			}

			CriticalValue = (decimal)ChiSquared.InvCDF(Probabilities.Length - 1, 1 - 0.05);
			if (ChiSquare <= CriticalValue) ChiSquareTest = true;
			else ChiSquareTest = false;
		}

		private decimal[] TheoreticalProbs(decimal p, int n)
		{
			decimal[] probs = new decimal[n];
			for (int i = 0; i < n - 1; i++)
			{
				probs[i] = p * (decimal)Math.Pow((double)(1 - p), i);
			}
			probs[n - 1] = 1 - probs.Sum();

			return probs;
		}

		private decimal[] EmpiricalProbs(decimal[] frequency, int n)
		{
			decimal[] probs = new decimal[frequency.Length];
			for (int i = 0; i < probs.Length; i++)
			{
				probs[i] = frequency[i] / n;
			}

			return probs;
		}

		private decimal[] Generator(decimal p, int n)
		{
			SortedDictionary<int, int> frequency = new SortedDictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				int x = 0;
				var alpha = random.NextDouble();

				x += (int)(Math.Log(alpha) / Math.Log(1 - (double)p));

				if (!frequency.ContainsKey(x))
				{
					frequency[x] = 1;
				}
				else frequency[x]++;
			}

			decimal[] res = new decimal[frequency.Last().Key];
			for (int i = 0; i < res.Length; i++)
			{
				res[i] = frequency.ContainsKey(i) ? frequency[i] : 0;
			}

			return res;
		}

	}
}
