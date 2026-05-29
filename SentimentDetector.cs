using System;

namespace CybersecurityChatbot
{
    public enum Sentiment { Neutral, Worried, Curious, Frustrated }
    public class SentimentDetector
    {
        

		private static readonly Dictionary<string, Sentiment> KeywordSentiments = new()
        {
            { "worried", Sentiment.Worried },
            { "concerned", Sentiment.Worried },
            { "anxious", Sentiment.Worried },
            { "hacked", Sentiment.Worried },
            { "curious", Sentiment.Curious },
            { "interested", Sentiment.Curious },
            { "how", Sentiment.Curious },
            { "frustrated", Sentiment.Frustrated },
            { "annoyed", Sentiment.Frustrated },
            { "confused", Sentiment.Frustrated },
            { "don't understand", Sentiment.Frustrated }
        };

    public Sentiment Detect(string Input)
    {
        string lowerInput = Input.ToLower();
        foreach (var kvp in KeywordSentiments)
            if (lowerInput.Contains(kvp.Key))
                return kvp.Value;
        return Sentiment.Neutral;
    }

    public string GetSentimentResponse(Sentiment sentiment)
    {
        return sentiment switch
        {
            Sentiment.Worried => "I can sense you're worried - that's completely understandable. Let me help you stay safe.",
            Sentiment.Curious => "It's great that you're curious! Learning about cybersecurity is important for staying safe online.",
            Sentiment.Frustrated => "I'm sorry you're feeling frustrated. Let me try to explain this more clearly.",
            _ => "Thanks for sharing your thoughts! How can I assist you further?"
        };
    }
}
