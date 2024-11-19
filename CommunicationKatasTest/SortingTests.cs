using FluentAssertions;
using Sorting;

namespace CommunicationKatasTest
{
	internal class SortingTests
	{
		private BubbleSort bubbleSort = new BubbleSort();
		private SelectionSort selectionSort = new SelectionSort();

		public static TestCaseData[] sortingTestData =
		[
			new( new[] { 1,2,3 }, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];

		[TestCaseSource(nameof(sortingTestData))]
		public void BubbleSortTest(int[] input, int[] expectedResult)
		{
			// Act
			var actualResult = bubbleSort.Sort(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		[TestCaseSource(nameof(sortingTestData))]
		public void SelectionSortTest(int[] input, int[] expectedResult)
		{
			// Act
			var actualResult = selectionSort.Sort(input);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
