using CommunicationKatas;
using FluentAssertions;

namespace CommunicationKatasTest
{
    public class Tests
    {
        public NumberManipulator testManipulator = new NumberManipulator();
        
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SumMiddleRangeTest()
        {
            double result1 = testManipulator.SumMiddleRange([5, 2, 6, 10, 22]); //Should be 21
            double result2 = testManipulator.SumMiddleRange([1, 2, 3, 4, 5]); // Should be 9
            double result3 = testManipulator.SumMiddleRange([1]); // should be 0
            double result4 = testManipulator.SumMiddleRange([1, 2]); // should be 0
            double result5 = testManipulator.SumMiddleRange([1, 2, 3]); // should be 2
            double result6 = testManipulator.SumMiddleRange([]); // should be 0
            double result7 = testManipulator.SumMiddleRange([0, -2, 20, 4, -5]); // should be 2

            result1.Should().Be(21);
            result2.Should().Be(9);
            result3.Should().Be(0);
            result4.Should().Be(0);
            result5.Should().Be(2);
            result6.Should().Be(0);
            result7.Should().Be(2);
        }

        [Test]
        public void GetMeanTest()
        {
            double result1 = testManipulator.GetMean([1, 2, 3]); // Should be 2
            double result2 = testManipulator.GetMean([40, 16, 5, 8]); // Should be 17.25
            double result3 = testManipulator.GetMean([]); // Should be 0

            result1.Should().Be(2);
            result2.Should().Be(17.25);
            result3.Should().Be(0);
        }

        [Test]
        public void GetAsciiSumTest()
        {
            int result1 = testManipulator.GetAsciiSum("northcoders"); // should be 1195
            int result2 = testManipulator.GetAsciiSum("Northcoders"); // should be 1163
            int result3 = testManipulator.GetAsciiSum("a"); // should be 97
            int result4 = testManipulator.GetAsciiSum(""); // should be 0
            int result5 = testManipulator.GetAsciiSum("^£&*^£&a^&"); // should be 97

            result1.Should().Be(1195);
            result2.Should().Be(1163);
            result3.Should().Be(97);
            result4.Should().Be(0);
            result5.Should().Be(97);
        }
    }
}