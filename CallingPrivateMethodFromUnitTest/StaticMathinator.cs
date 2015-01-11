using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingPrivateMethodFromUnitTest
{
	public static class  StaticMathinator
	{
		private static double AddNumbers(double[] inputs)
		{
			double total = 0;

			foreach (var item in inputs)
			{
				total += item;
			}

			return total;
		}
	}
}
