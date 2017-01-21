using NUnit.Framework;

namespace SwingCalculator.Test
{
	[TestFixture]
	public class SwingCalculatorTests {
		[Test]
		public void InputNumberTwo() {
			Calculator.Two();
			Assert.AreEqual(2, Calculator.Equals());
		}

		[Test]
		public void InputNumberThree() {
			Calculator.Three();
			Assert.AreEqual(3, Calculator.Equals());
		}

		[Test]
		public void InputNumberFive() {
			Calculator.Five();
			Assert.AreEqual(5, Calculator.Equals());
		}

		[Test]
		public void InputTwoNumbersOfSameValue() {
			Calculator.Two();
			Calculator.Two();
			Assert.AreEqual(22, Calculator.Equals());
		}

		[Test]
		public void InputTwoNumbersOfDifferentValue() {
			Calculator.Two();
			Calculator.Three();
			Assert.AreEqual(23, Calculator.Equals());
		}

		[Test]
		public void InputXNumbersOfSameValue() {
			Calculator.Two();
			Calculator.Two();
			Calculator.Two();
			Calculator.Two();
			Assert.AreEqual(2222, Calculator.Equals());
		}

		[Test]
		public void InputXNumbersOfDifferentValue() {
			Calculator.Two();
			Calculator.Three();
			Calculator.Three();
			Calculator.Five();
			Calculator.Two();
			Assert.AreEqual(23352, Calculator.Equals());
		}

		[Test]
		public void AddTwoNumbersOfSameValue() {
			Calculator.Two();
			Calculator.Add();
			Calculator.Two();
			Assert.AreEqual(4, Calculator.Equals());
		}

		[Test]
		public void AddXNumbersOfSameValue() {
			Calculator.Two();
			Calculator.Add();
			Calculator.Two();
			Calculator.Add();
			Calculator.Two();
			Assert.AreEqual(6, Calculator.Equals());
		}

		[Test]
		public void SubtractSingleNumberFromGreaterNumber() {
			Calculator.Five();
			Calculator.Subtract();
			Calculator.Two();
			Assert.AreEqual(3, Calculator.Equals());
		}

		[Test]
		public void SubtractXNumbersFromGreaterNumber() {
			Calculator.Five();
			Calculator.Five();
			Calculator.Subtract();
			Calculator.Two();
			Calculator.Subtract();
			Calculator.Two();
			Calculator.Three();
			Assert.AreEqual(30, Calculator.Equals());
		}

		[Test]
		public void ResetsAfterEquals() {
			Calculator.Five();
			Calculator.Subtract();
			Calculator.Two();
			Calculator.Equals();
			Calculator.Two();
			Assert.AreEqual(2, Calculator.Equals());
		}

		[Test]
		public void AddTwoNumberSubtractLesserNumber() {
			Calculator.Five();
			Calculator.Add();
			Calculator.Five();
			Calculator.Subtract();
			Calculator.Two();
			Assert.AreEqual(8, Calculator.Equals());
		}

		[Test]
		public void SubtractNumberGreaterThanCurrentValue() {
			Calculator.Two();
			Calculator.Subtract();
			Calculator.Five();
			Assert.AreEqual(-3, Calculator.Equals());
		}

		[Test]
		public void ClearResetsCalculator() {
			Calculator.Five();
			Calculator.Three();
			Calculator.Clear();
			Assert.AreEqual(0, Calculator.Equals());
		}

		protected Model.SwingCalculator Calculator;

		[SetUp]
		public void Setup() {
			Calculator = new Model.SwingCalculator();
		}
	}
}