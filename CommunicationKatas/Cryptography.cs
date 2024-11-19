using System.Text;

namespace CommunicationKatas
{
	public class Cryptography
	{
		public string ROT13Encoder(string message)
		{
			var sb = new StringBuilder();

			foreach (char c in message)
			{
				if (!char.IsLetter(c))
				{
					sb.Append(c);
					continue;
				}

				int startOfValidAsciiValues = char.IsUpper(c)
					? (int)'A'
					: (int)'a';

				int endOfValidAsciiValues = char.IsUpper(c)
					? (int)'Z' + 1
					: (int)'z' + 1;

				int unloopedAsciiValue = (int)c + 13;

				int shiftedAsciiValue = unloopedAsciiValue >= endOfValidAsciiValues
					? startOfValidAsciiValues + (unloopedAsciiValue % endOfValidAsciiValues)
					: unloopedAsciiValue;

				sb.Append((char)shiftedAsciiValue);
			}

			return sb.ToString();
		}
	}
}