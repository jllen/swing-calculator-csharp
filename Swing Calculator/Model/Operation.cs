namespace SwingCalculator.Model
{
	public abstract class Operation: IOperation {
		protected SwingNumber Value = new SwingNumber();
		protected SwingNumber Operand = new SwingNumber();

		public int Sum() {
			Value = ApplySum();
			Operand = new SwingNumber();
			return Value.Value;
		}

		protected abstract SwingNumber ApplySum();

		public void Append(int value) {
			Operand.Append(value);
		}
	}

	public class NoOperation: Operation {
		protected override SwingNumber ApplySum() {
			return Operand;
		}
	}

	public class AddOperation: Operation {
		public AddOperation(int startingValue) {
			Value = new SwingNumber(startingValue);
		}

		protected override SwingNumber ApplySum(){
			return new SwingNumber(Value.Value + Operand.Value);
		}
	}

	public class SubtractOperation: Operation {
		public SubtractOperation(int startingValue) {
			Value = new SwingNumber(startingValue);
		}

		protected override SwingNumber ApplySum() {
			return new SwingNumber(Value.Value - Operand.Value);
		}
	}
}