using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class CryptographyTests
	{
		Cryptography cryptography = new();

		public static TestCaseData[] ROT13TestData =
		[
			new("northcoders", "abegupbqref"),
			new("abegupbqref", "northcoders"),
			new("I'm sure glad nobody can read my secret ROT13 code.", "V'z fher tynq abobql pna ernq zl frperg EBG13 pbqr.")
		];

		[TestCaseSource(nameof(ROT13TestData))]
		public void ROT13EncoderTest_ReturnsExpectedResult(string input, string expectedResult)
		{
			// Act
			string actualResult = cryptography.ROT13Encoder(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
