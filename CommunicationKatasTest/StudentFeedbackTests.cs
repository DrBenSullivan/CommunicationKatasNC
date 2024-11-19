using CommunicationKatas;
using CommunicationKatas.Enums;
using FluentAssertions;

namespace CommunicationKatasTest
{
	internal class StudentFeedbackTests
	{
		private StudentFeedback studentFeedback;

		[SetUp]
		public void SetUp()
		{
			studentFeedback = new StudentFeedback();
		}

		[Test]
		public void ResolveFeedBackFromClicks_ReturnsExpectedValue()
		{
			// Arrange
			Feedback[] input1 = [Feedback.LIKE, Feedback.DISLIKE];
			Feedback expectedResult1 = Feedback.NEUTRAL;
			Feedback[] input2 = [Feedback.LIKE];
			Feedback expectedResult2 = Feedback.LIKE;
			Feedback[] input3 = [Feedback.DISLIKE, Feedback.DISLIKE];
			Feedback expectedResult3 = Feedback.NEUTRAL;
			Feedback[] input4 = [];
			Feedback expectedResult4 = Feedback.NEUTRAL;
			Feedback[] input5 = [Feedback.LIKE, Feedback.DISLIKE, Feedback.DISLIKE, Feedback.LIKE, Feedback.DISLIKE, Feedback.DISLIKE, Feedback.LIKE];
			Feedback expectedResult5 = Feedback.LIKE;

			// Act
			Feedback actualResult1 = studentFeedback.ResolveFeedbackFromClicks(input1);
			Feedback actualResult2 = studentFeedback.ResolveFeedbackFromClicks(input2);
			Feedback actualResult3 = studentFeedback.ResolveFeedbackFromClicks(input3);
			Feedback actualResult4 = studentFeedback.ResolveFeedbackFromClicks(input4);
			Feedback actualResult5 = studentFeedback.ResolveFeedbackFromClicks(input5);

			// Assert
			actualResult1.Should().Be(expectedResult1);
			actualResult2.Should().Be(expectedResult2);
			actualResult3.Should().Be(expectedResult3);
			actualResult4.Should().Be(expectedResult4);
			actualResult5.Should().Be(expectedResult5);
		}
	}
}
