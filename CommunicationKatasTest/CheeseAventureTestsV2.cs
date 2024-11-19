using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class CheeseAventureTestsV2
	{
		CheeseAdventureV2 cheeseAdventureV2 = new();

		public static TestCaseData[] cheesePartyDeterminerV2TestData =
		[
			new("---K-----M---C--", 6, 0, "No cheese"),
			new("---K-----M---C--", 0, 6, "Cheese"),
			new("---K-----M---C--", 1, 1, "Cheese"),
			new("---K-----M---C--", 3, 1, "No cheese"),
			new("---K---M---C--", 2, 1, "Cheese party!"),
			new("---M-----K---C--", 6, 6, "Cheese"),
			new("---M-----K---C--", -1, 1, "No cheese"),
			new("---K----M--------C--", -1, 1, "Cheese"),
			new("---K--C--M---", -1, 1, "Everyone goes hungry!")
		];

		[TestCaseSource(nameof(cheesePartyDeterminerV2TestData))]
		public void CheesePartyDeterminerV2Test_ValidArguments_ReturnsExpectedResult(string grid, int catSpeed, int mouseSpeed, string expectedResult)
		{
			// Act
			string actualResult = cheeseAdventureV2.CheesePartyDeterminerV2(grid, catSpeed, mouseSpeed);

			// Assert
			actualResult.Should().Be(expectedResult);
		}

		public static TestCaseData[] cheesePartyDeterminerV2ArgumentTestData =
		[
			new("--M--K---K--C"),
			new("---K*-----M---C--")
		];

		[TestCaseSource(nameof(cheesePartyDeterminerV2ArgumentTestData))]
		public void CheesePartyDeterminerV2Test_InvalidArguments_ReturnsArgumentException(string grid)
		{
			// Arrange
			Action test = () => cheeseAdventureV2.CheesePartyDeterminerV2(grid, -2, 0);

			// Assert & Act
			test.Should().Throw<ArgumentException>();
		}
	}
}
