using NUnit.Framework;
using SwingCalculator.Model;

namespace SwingCalculator.Test
{
	[TestFixture]
	public class SwingNumberTests {
		[Test]
		public void ValueIsZeroOnInitialisation() {
			var number = new SwingNumber();
			Assert.AreEqual(0, number.Value);
		}

		[Test]
		public void InitialisesWithValue() {
			var number = new SwingNumber(2);
			Assert.AreEqual(2, number.Value);
		}

		[Test]
		public void AppendSingleValue() {
			var number = new SwingNumber();
			number.Append(2);
			Assert.AreEqual(2, number.Value);
		}

		[Test]
		public void AppendXLikeValues() {
			var number = new SwingNumber();
			number.Append(2);
			number.Append(2);
			number.Append(2);
			Assert.AreEqual(222, number.Value);
		}

		[Test]
		public void AppendXDifferingValues() {
			var number = new SwingNumber();
			number.Append(2);
			number.Append(5);
			number.Append(3);
			Assert.AreEqual(253, number.Value);
		}
	}
}