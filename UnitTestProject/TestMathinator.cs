using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CallingPrivateMethodFromUnitTest;

namespace UnitTestProject
{
	[TestClass]
	public class TestMathinator
	{
		[TestMethod]
		public void TestPrivateMethod()
		{
			double [] input = new double [3];
			input[0] = 3;
			input[1] = 12.4;
			input[2] = 3.45;

			Mathinator mathinator = new Mathinator();
			var mathinatorObject = new PrivateObject(mathinator);
			double result = (double)mathinatorObject.Invoke("AddList",input);

			Assert.AreEqual(18.85, result);
		}

		[TestMethod]
		public void TestStaticPrivateMethod()
		{
			double[] input = new double[3];
			input[0] = 3;
			input[1] = 12.4;
			input[2] = 3.45;

			var privateHelperType = new PrivateType(typeof(StaticMathinator));
			double result = (double)privateHelperType.InvokeStatic("AddNumbers", input);

			Assert.AreEqual(18.85, result);
		}
	}
}
