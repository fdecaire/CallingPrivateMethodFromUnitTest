using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingPrivateMethodFromUnitTest
{
	public class Mathinator
	{
		private double AddList(double[] inputs)
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
