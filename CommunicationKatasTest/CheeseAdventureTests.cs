using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class CheeseAdventureTests
	{
		CheeseAdventure cheeseAdventure = new();

		public static TestCaseData[] cheesePartyDeterminerData =
		[
			new("---K-----M---C--", 6, 0, "No cheese"),
			new("---K-----M---C--", 0, 6, "Cheese"),
			new("---K-----M---C--", 1, 1, "Cheese"),
			new("---K-----M---C--", 3, 1, "No cheese"),
			new("---K---M---C--", 2, 1, "Cheese party!"),
			new("---K-----M---C--", 6, 0, "No cheese"),
			new("---K-----M---C--", 6, 0, "No cheese"),

		];

		[TestCaseSource(nameof(cheesePartyDeterminerData))]
		public void CheesePartyDeterminerTest_ValidArguments_ReturnExpectedString(string grid, int catSpeed, int mouseSpeed, string expectedResult)
		{
			// Act
			string actualResult = cheeseAdventure.CheesePartyDeterminer(grid, catSpeed, mouseSpeed);

			// Assert
			actualResult.Should().Be(expectedResult);
		}


		public static TestCaseData[] cheesePartyDeterminerExceptionData =
		[
			new("--M-----K--C", 2, 1),
			new("---K-----M---C--", -4, -2)
		];

		[TestCaseSource(nameof(cheesePartyDeterminerExceptionData))]
		public void CheesePartyDeterminerTest_InvalidGrid_ThrowsArgumentException(string grid, int catSpeed, int mouseSpeed)
		{
			// Arrange
			Action test = () => cheeseAdventure.CheesePartyDeterminer(grid, catSpeed, mouseSpeed);

			// Act & Assert
			test.Should().Throw<ArgumentException>();
		}
	}
}
