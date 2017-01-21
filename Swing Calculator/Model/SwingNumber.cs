using System.Globalization;

namespace SwingCalculator.Model {
	public class SwingNumber {
		private string _inputString = "";

		public SwingNumber() {
			_inputString += 0.ToString(CultureInfo.InvariantCulture);
		}

		public SwingNumber(int value) {
			_inputString += value.ToString(CultureInfo.InvariantCulture);
		}

		public int Value {
			get { return int.Parse(_inputString); }
		}

		public void Append(int value) {
			_inputString += value.ToString(CultureInfo.InvariantCulture);
		}
	}
}