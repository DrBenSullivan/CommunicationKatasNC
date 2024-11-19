using FluentAssertions;
using Sorting;

namespace CommunicationKatasTest
{
	internal class SortingTests
	{
		private BubbleSort<int> bubbleSort = new ();
		//private SelectionSort selectionSort = new ();
		//private InsertionSort insertionSort = new ();

		public static TestCaseData[] bubbleSortTestData =
		[
			new( new[] { 1,2,3 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, Comparer<int>.Default, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];

		[TestCaseSource(nameof(bubbleSortTestData))]
		public void BubbleSortTest(int[] input, IComparer<int> comparer, int[] expectedResult)
		{
			// Act
			var actualResult = bubbleSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		//public static TestCaseData[] selectionSortTestData =
		//[
		//	new( new[] { 1,2,3 }, new[] { 1,2,3 } ),
		//	new( new[] { 3,2,1 }, new[] { 1,2,3 } ),
		//	new( new[] { 10,9,8,7,6,5,4,3,2,1 }, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		//];

		//[TestCaseSource(nameof(selectionSortTestData))]
		//public void SelectionSortTest(int[] input, int[] expectedResult)
		//{
		//	// Act
		//	var actualResult = selectionSort.Sort(input);

		//	// Assert
		//	actualResult.Should().BeEquivalentTo(expectedResult);
		//}

		//public static TestCaseData[] insertionSortTestData =
		//[
		//	new( new[] { 1,2,3 }, new[] { 1,2,3 } ),
		//	new( new[] { 3,2,1 }, new[] { 1,2,3 } ),
		//	new( new[] { 10,9,8,7,6,5,4,3,2,1 }, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		//];

		//[TestCaseSource(nameof(insertionSortTestData))]
		//public void InsertionSortTest(int[] input, int[] expectedResult)
		//{
		//	// Act
		//	var actualResult = insertionSort.Sort(input);

		//	// Assert
		//	actualResult.Should().BeEquivalentTo(expectedResult);
		//}

	}
}
