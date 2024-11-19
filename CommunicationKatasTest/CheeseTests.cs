using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class CheeseTests
	{
		CheeseAdventure testAdventure = new CheeseAdventure();

		[Test]
		public void CheesePartyDeterminerTest()
		{
			string noCheeseResult = "No cheese";
			string cheeseResult = "Cheese";
			string cheesePartyResult = "Cheese party!";

			string result1 = testAdventure.CheesePartyDeterminer("---K-----M---C--", 6, 0); // should return "No cheese"
			string result2 = testAdventure.CheesePartyDeterminer("---K-----M---C--", 0, 6); // should return "Cheese"
			string result3 = testAdventure.CheesePartyDeterminer("---K-----M---C--", 1, 1); // should return "Cheese"
			string result4 = testAdventure.CheesePartyDeterminer("---K-----M---C--", 3, 1); // should return "No cheese"
			string result5 = testAdventure.CheesePartyDeterminer("---K---M---C--", 2, 1); // should return "Cheese party!"
			Action test6 = () => testAdventure.CheesePartyDeterminer("--M-----K--C", 2, 1); // should string exception
			Action test7 = () => testAdventure.CheesePartyDeterminer("---K-----M---C--", -4, -2); // should throw speed exception

			result1.Should().Be(noCheeseResult);
			result2.Should().Be(cheeseResult);
			result3.Should().Be(cheeseResult);
			result4.Should().Be(noCheeseResult);
			result5.Should().Be(cheesePartyResult);
			test6.Should().Throw<ArgumentException>();
			test7.Should().Throw<ArgumentException>();


		}
	}
}
