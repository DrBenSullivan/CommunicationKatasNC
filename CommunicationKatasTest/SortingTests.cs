using FluentAssertions;
using Sorting;

namespace CommunicationKatasTest
{
	internal class SortingTests
	{
		private BubbleSort bubbleSort = new BubbleSort();
		private SelectionSort selectionSort = new SelectionSort();
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

		[Test]
		public void SelectionSortTest()
		{
			var result1 = selectionSort.Sort([1, 2, 3]);
			var result2 = selectionSort.Sort([3, 2, 1]);
			var result3 = selectionSort.Sort([10, 9, 8, 7, 6, 5, 4, 3, 2, 1]);
			result1.Should().BeEquivalentTo([1, 2, 3]);
			result2.Should().BeEquivalentTo([1, 2, 3]);
			result3.Should().BeEquivalentTo([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
		}
	}
}
