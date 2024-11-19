using FluentAssertions;

namespace CommunicationKatasTest
{
	public class BubbleSortTests
	{
		private BubbleSort bubbleSort = new BubbleSort();

		[Test]
		public void BubbleSortTest()
		{
			var result1 = bubbleSort.Sort([1, 2, 3]);
			var result2 = bubbleSort.Sort([3, 2, 1]);
			var result3 = bubbleSort.Sort([10, 9, 8, 7, 6, 5, 4, 3, 2, 1]);

			result1.Should().BeEquivalentTo([1, 2, 3]);
			result2.Should().BeEquivalentTo([1, 2, 3]);
			result3.Should().BeEquivalentTo([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
		}

	}
}
