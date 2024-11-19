using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
	public class NumberManipulatorTests
	{
		public NumberManipulator numberManipulator = new();

		public static TestCaseData[] sumMiddleRangeTestData =
		[
			new(new[] { 5d , 2d, 6d, 10d, 22d }, 21d ),
			new(new[] { 1d , 2d, 3d, 4d, 5d }, 9d ),
			new(new[] { 1d }, 0d ),
			new(new[] { 1d , 2d }, 0d ),
			new(new[] { 1d , 2d, 3d }, 2d ),
			new(Array.Empty<double>(), 0d ),
			new(new[] { 0d, -2d, 20d, 4d, -5d}, 2d )
		];

		[TestCaseSource(nameof(sumMiddleRangeTestData))]
		public void SumMiddleRangeTest(double[] input, double expectedResult)
		{
			// Act
			double actualResult = numberManipulator.SumMiddleRange(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}

		public static TestCaseData[] getMeanTestData =
		[
			new(new[] { 1d, 2d, 3d }, 2d ),
			new(new[] { 1d, 2d, 3d, 4d, 5d }, 3d),
			new(Array.Empty<double>(), 0d)
		];

		[TestCaseSource(nameof(getMeanTestData))]
		public void GetMeanTest(double[] input, double expectedResult)
		{
			// Act
			double actualResult = numberManipulator.GetMean(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}

		public static TestCaseData[] getAsciiSumTestData =
		[
			new("northcoders", 1195),
			new("Northcoders", 1163),
			new("a", 97),
			new(string.Empty, 0),
			new("^£&*^£&a^&", 97)
		];

		[TestCaseSource(nameof(getAsciiSumTestData))]
		public void GetAsciiSumTest(string input, int expectedResult)
		{
			// Act
			int actualResult = numberManipulator.GetAsciiSum(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}