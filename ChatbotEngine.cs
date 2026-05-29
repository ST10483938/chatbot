using System;

namespace CybersecurityChatbot
{
    public class ChatbotEngine
    {
        private readonly MemoryStore memoryStore;
        private readonly SentimentDetector sentimentDetector;
        private readonly Responses responses;
        public ChatbotEngine()
        {
            memoryStore = new MemoryStore();
            sentimentDetector = new SentimentDetector();
            responses = new Responses();


            private string lastTopic = string.Empty;

        public (string response, Sentiment sentiment) ProcessInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return ("Please enter a question first.", Sentiment.Neutral);

            string lowerInput = input.ToLower();


            // Memory: store name if user introduces themselves
            if (lowerInput.Contains("my name is") || lowerInput.Contains("i am") || lowerInput.Contains("i'm"))
            {

                string name = input.ToLower().Replace("my name is", "").Trim();
                name = char.ToUpper(name[0]) + name.Substring(1);
                memoryStore.UserName = name;
                memoryStore.Remember("user_name", name);
                return ($"Nice to meet you, {name}! I'll remeber that. How can I help you with cybersecurity today?", Sentiment.Neutral);
            }

            //Memory: recall name if user asks
            if (lowerInput.Contains("what do you remember") || lowerInput.Contains("what do you know about me"))
            {
                return ($"Here's what I remember about you: {memoryStore.Recall("user_name")}", Sentiment.Neutral);
            }

            // Conversation flow: detect sentiment and respond accordingly
            if (lowerInput.Contains("tell me more") || lowerInput.Contains("give me another tip")) || lowerInput.Contains("i don't understand") || lowerInput.Contains("can you explain") || lowerInput.Contains("explain")) || lowerInput.Contains("more details") && !string.IsNullOrEmpty(lastTopic))

            {
                string followUp = responses.GetFollowUpResponse(lastTopic);
                return ($"Sure! Here's more about {lastTopic}: {followUp}", Sentiment.Neutral);
            }

            // Detect sentiment
            Sentiment sentiment = sentimentDetector.Detect(input);
            string sentimentResponse = sentimentDetector.GetSentimentResponse(sentiment);

            // Get main response based on input
            string mainResponse = responses.GetResponse(input);

            // track last topic for follow-up questions
            foreach (string topic in new[] { "cybersecurity", "phishing", "malware", "ransomware", "passwords" })
            {
                if (lowerInput.Contains(topic))
                {
                    lastTopic = topic;
                    break;
                }
            }

            string fullResponse = string.IsNullOrEmpty(sentimentResponse) ? mainResponse : $"{mainResponse} {sentimentResponse}";
            return (fullResponse, sentiment);
        }
    }
}
