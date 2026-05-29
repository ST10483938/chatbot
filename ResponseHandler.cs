using System;

namespace CybersecurityChatbot
{
    public class Responses
    {
        private readonly Random_rng = new ()


            private readonly Dictionary<string, List<string>> ResponseTemplates = new()
            {
                {
                "password", new()
                {
                    "Make sure to use  strong, unique passwords for each of your accounts. Avoid personal details like birthdays.",
                    "A good password should be at least 12 characters long and include a mix of letters, numbers, and symbols.",
                    "Never reuse passwords. If one account is breached, all accounts stay safe with unique passwords."
                }
    },
                {
                    "phishing", new()
                {
                    "Be cautious of emails or messages asking for personal information. Always verify the sender's identity.",
                    "Phishing attempts often create a sense of urgency. Take a moment to think before clicking any links.",
                    "If an email looks suspicious, don't click on any links or download attachments. Report it to your email provider."
                }
    },

                {
                    "scam", new()
                {
                    "Be wary of offers that seem too good to be true. Scammers often use enticing deals to lure victims.",
                    "Never share personal or financial information with unknown sources. Verify the legitimacy of any offer before proceeding.",
                    "If you suspect a scam, report it to the appropriate authorities and warn others to prevent them from falling victim."
                }
},
                {
                    "privacy", new()
                    {
                        "Protect your privacy by adjusting the settings on your social media accounts. Limit who can see your information.",
                        "Be mindful of the information you share online. Even seemingly harmless details can be used to piece together your identity.",
                        "Use a VPN when browsing on public Wi-Fi to help protect your data from potential eavesdroppers."
                    }
                },
                {
                    "malware", new()
                    {
                        "Keep your software and antivirus programs up to date to protect against malware threats.",
                        "Be cautious when downloading files or clicking on links, especially from unknown sources, as they may contain malware.",
                        "Regularly back up your important data to an external drive or cloud service in case of a malware attack."
                    }
                },
                {
                    "vpn", new()
                    {
                        "A VPN (Virtual Private Network) can help protect your online privacy by encrypting your internet connection.",
                        "Using a VPN can help you access content that may be restricted in your region while keeping your data secure.",
                        "When choosing a VPN, look for one with strong encryption, a no-logs policy, and good performance."
                    }
                },
                {
                    "what can i ask", new()
                    {
                        "You can ask me about best practices for online safety, how to recognize scams, or tips for protecting your privacy.",
                        "I'm here to help with any cybersecurity questions you have, whether it's about password security, phishing, or general online safety.",
                        "Feel free to ask me anything related to cybersecurity, and I'll do my best to provide helpful information!"
                    }
                };



        public string GetResponse(string input);
        {
            if (string.IsNullOrWhiteSpace(input))

                return null;
            }
            string lowerInput = input.ToLower();
            foreach (var kvp in ResponseTemplates)
            {
                if (lowerInput.Contains(kvp.Key))
                {
                    int index = _rng.Next(kvp.Value.Count);
                    return kvp.Value[index];
                }
            }

            return "I didn't quite understand that. Could you please rephrase or ask about something else related to cybersecurity?" +
                "Try asking about: passwords, phishing. scam, privacy, malware, vpn, or what can I ask";
        }
    }
}

