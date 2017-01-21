namespace SwingCalculator.Model
{
	public class SwingCalculator {
		private IOperation _operation = new NoOperation();

		public void Two() {
			_operation.Append(2);
		}

		public void Three() {
			_operation.Append(3);
		}

		public void Five() {
			_operation.Append(5);
		}

		public void Add() {
			_operation = new AddOperation(_operation.Sum());
		}

		public void Subtract() {
			_operation = new SubtractOperation(_operation.Sum());
		}

		public int Equals() {
			var sum = _operation.Sum();
			Clear();
			return sum;
		}

		public void Clear() {
			_operation = new NoOperation();
		}
	}
}