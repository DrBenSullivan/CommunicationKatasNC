namespace CommunicationKatas
{
	public class NumberManipulator
	{
		public double SumMiddleRange(double[] numbers)
		{
			double lowestNumber = double.MaxValue;
			double highestNumber = double.MinValue;

			foreach (double number in numbers)
			{
				if (number < lowestNumber) lowestNumber = number;

				if (number > highestNumber) highestNumber = number;
			}

			return numbers.Where(n => n != lowestNumber && n != highestNumber).Sum();
		}

		public double GetMean(double[] numbers)
		{
			if (numbers.Length == 0) return 0;

			return numbers.Sum() / numbers.Length;
		}

		public int GetAsciiSum(string str)
		{
			int total = 0;

			foreach (char c in str)
			{
				if (Char.IsLetterOrDigit(c)) total += (int)c;
			}

			return total;
		}
	}
}
