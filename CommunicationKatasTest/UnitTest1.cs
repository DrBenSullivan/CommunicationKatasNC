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
    }
}