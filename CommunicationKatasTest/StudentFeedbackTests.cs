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

		private static TestCaseData[] feedbackData =>
		[
			new TestCaseData(new[] { Feedback.LIKE, Feedback.DISLIKE }, Feedback.NEUTRAL),
			new TestCaseData(new[] { Feedback.LIKE }, Feedback.LIKE),
			new TestCaseData(new[] { Feedback.DISLIKE, Feedback.DISLIKE }, Feedback.NEUTRAL),
			new TestCaseData(Array.Empty<Feedback>(), Feedback.NEUTRAL),
			new TestCaseData(
				new[] { Feedback.LIKE, Feedback.DISLIKE, Feedback.DISLIKE, Feedback.LIKE, Feedback.DISLIKE, Feedback.DISLIKE, Feedback.LIKE },
				Feedback.LIKE
			)
		];

		[TestCaseSource(nameof(feedbackData))]
		public void ResolveFeedBackFromClicks_ReturnsExpectedValue(Feedback[] input, Feedback expectedResult)
		{
			// Act
			Feedback actualResult = studentFeedback.ResolveFeedbackFromClicks(input);

			// Assert
			actualResult.Should().Be(expectedResult);
		}
	}
}
