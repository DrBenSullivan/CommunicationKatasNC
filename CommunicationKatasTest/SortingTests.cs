using FluentAssertions;
using Sorting;

namespace CommunicationKatasTest
{
	internal class SortingTests
	{

		//private SelectionSort selectionSort = new ();
		//private InsertionSort insertionSort = new ();

		public static TestCaseData[] bubbleSortIntTestData =
		[
			new( new[] { 1,2,3 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, Comparer<int>.Default, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];

		[TestCaseSource(nameof(bubbleSortIntTestData))]
		public void BubbleSortIntTest(int[] input, IComparer<int> comparer, int[] expectedResult)
		{
			// Arrange 
			BubbleSort<int> bubbleSort = new ();

			// Act
			var actualResult = bubbleSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		public static Person person1 = new (1, 190f, 50);
		public static Person person2 = new (2, 170f, 60);
		public static Person person3 = new (3, 150f, 40);

		public static TestCaseData[] bubbleSortPersonTestData =
		[
			new( new[] { person1, person2, person3 }, new HeightComparison(), new[] { person1, person2, person3 } ),
			new( new[] { person1, person2, person3 }, new AgeComparison(), new[] { person3, person1, person2 } ),
			new( new[] { person3, person1, person2 }, new IdComparison(), new[] { person1, person2, person3 } )
		];

		[TestCaseSource(nameof(bubbleSortPersonTestData))]
		public void BubbleSortIntTest(Person[] input, IComparer<Person> comparer, Person[] expectedResult)
		{
			// Arrange
			BubbleSort<Person> bubbleSort = new ();

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
