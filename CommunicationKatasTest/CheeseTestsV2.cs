using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class CheeseTestsV2
	{
		CheeseAdventureV2 testAdventure = new CheeseAdventureV2();

		[Test]
		public void CheesePartyDeterminerV2Test()
		{
			string noCheeseResult = "No cheese";
			string cheeseResult = "Cheese";
			string cheesePartyResult = "Cheese party!";
			string noCollisionsResult = "Everyone goes hungry!";

			string result1 = testAdventure.CheesePartyDeterminerV2("---K-----M---C--", 6, 0); // should return "No cheese"
			string result2 = testAdventure.CheesePartyDeterminerV2("---K-----M---C--", 0, 6); // should return "Cheese"
			string result3 = testAdventure.CheesePartyDeterminerV2("---K-----M---C--", 1, 1); // should return "Cheese"
			string result4 = testAdventure.CheesePartyDeterminerV2("---K-----M---C--", 3, 1); // should return "No cheese"
			string result5 = testAdventure.CheesePartyDeterminerV2("---K---M---C--", 2, 1); // should return "Cheese party!"
			string result6 = testAdventure.CheesePartyDeterminerV2("---M-----K---C--", 6, 6); // should return "Cheese"
			string result7 = testAdventure.CheesePartyDeterminerV2("---M-----K---C--", -1, 1); // should return "No cheese"
			string result8 = testAdventure.CheesePartyDeterminerV2("---K----M--------C--", -1, 1); // should return "Cheese"
			string result9 = testAdventure.CheesePartyDeterminerV2("---K--C--M---", -1, 1); // should return "Everyone goes hungry!"

			Action test6 = () => testAdventure.CheesePartyDeterminerV2("--M--K---K--C", 2, 1); // should string exception
			Action test7 = () => testAdventure.CheesePartyDeterminerV2("---K*-----M---C--", -4, -2); // should throw speed exception


			result1.Should().Be(noCheeseResult);
			result2.Should().Be(cheeseResult);
			result3.Should().Be(cheeseResult);
			result4.Should().Be(noCheeseResult);
			result5.Should().Be(cheesePartyResult);
			result6.Should().Be(cheeseResult);
			result7.Should().Be(noCheeseResult);
			result8.Should().Be(cheeseResult);
			result9.Should().Be(noCollisionsResult);

			test6.Should().Throw<ArgumentException>();
			test7.Should().Throw<ArgumentException>();


		}
	}
}
