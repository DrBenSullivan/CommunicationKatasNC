using FluentAssertions;
using Sorting;

namespace CommunicationKatasTest
{
	internal class SortingTests
	{
		#region setup
		public static TestCaseData[] bubbleSortIntTestData =
		[
			new( new[] { 1,2,3 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, Comparer<int>.Default, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];
		#endregion
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

		#region setup
		public static Person person1 = new (1, 190f, 50);
		public static Person person2 = new (2, 170f, 60);
		public static Person person3 = new (3, 150f, 40);
		public static TestCaseData[] bubbleSortPersonTestData =
		[
			new( new[] { person1, person2, person3 }, new HeightComparison(), new[] { person1, person2, person3 } ),
			new( new[] { person1, person2, person3 }, new AgeComparison(), new[] { person3, person1, person2 } ),
			new( new[] { person3, person1, person2 }, new IdComparison(), new[] { person1, person2, person3 } )
		];
		#endregion
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

		#region setup
		public static TestCaseData[] selectionSortIntTestData =
		[
			new( new[] { 1,2,3 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, Comparer<int>.Default, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];
		#endregion
		[TestCaseSource(nameof(selectionSortIntTestData))]
		public void SelectionSortTest(int[] input, IComparer<int> comparer, int[] expectedResult)
		{
			// Arrange
			SelectionSort<int> selectionSort = new ();

			// Act
			var actualResult = selectionSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		#region setup
		public static TestCaseData[] selectionSortPersonTestData =
		[
			new( new[] { person1, person2, person3 }, new HeightComparison(), new[] { person1, person2, person3 } ),
			new( new[] { person1, person2, person3 }, new AgeComparison(), new[] { person3, person1, person2 } ),
			new( new[] { person3, person1, person2 }, new IdComparison(), new[] { person1, person2, person3 } )
		];
		#endregion
		[TestCaseSource(nameof(selectionSortPersonTestData))]
		public void SelectionSortTest(Person[] input, IComparer<Person> comparer, Person[] expectedResult)
		{
			// Arrange
			SelectionSort<Person> selectionSort = new ();

			// Act
			var actualResult = selectionSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		#region setup
		public static TestCaseData[] insertionSortIntTestData =
		[
			new( new[] { 1,2,3 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 3,2,1 }, Comparer<int>.Default, new[] { 1,2,3 } ),
			new( new[] { 10,9,8,7,6,5,4,3,2,1 }, Comparer<int>.Default, new[] { 1,2,3,4,5,6,7,8,9,10 } )
		];
		#endregion
		[TestCaseSource(nameof(insertionSortIntTestData))]
		public void InsertionSortTest(int[] input, IComparer<int> comparer, int[] expectedResult)
		{
			// Arrange
			InsertionSort<int> insertionSort = new ();

			// Act
			var actualResult = insertionSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}

		#region setup
		public static TestCaseData[] insertionSortPersonTestData =
		[
			new( new[] { person1, person2, person3 }, new HeightComparison(), new[] { person1, person2, person3 } ),
			new( new[] { person1, person2, person3 }, new AgeComparison(), new[] { person3, person1, person2 } ),
			new( new[] { person3, person1, person2 }, new IdComparison(), new[] { person1, person2, person3 } )
		];
		#endregion
		[TestCaseSource(nameof(insertionSortPersonTestData))]
		public void InsertionSortTest(Person[] input, IComparer<Person> comparer, Person[] expectedResult)
		{
			// Arrange
			InsertionSort<Person> insertionSort = new ();

			// Act
			var actualResult = insertionSort.Sort(input, comparer);

			// Assert
			actualResult.Should().BeEquivalentTo(expectedResult);
		}
	}
}
