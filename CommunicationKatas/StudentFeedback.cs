using CommunicationKatas.Enums;

namespace CommunicationKatas
{
	public class StudentFeedback
	{
		public Feedback ResolveFeedbackFromClicks(Feedback[] feedbackClicks)
		{
			if (feedbackClicks.Length % 2 == 0) return Feedback.NEUTRAL;
			return feedbackClicks[^1];
		}
	}
}
