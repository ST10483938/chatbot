
using System;

namespace CybersecurityChatbot
{
    public class MemoryStore
    {
        public string UserName { get; set; } = "User";
        public string FavouriteTopic { get; set; } = "Cybersecurity";
        public List<string> SessionNotes { get; set; } = new List<string>();

        public void Remember(string note)
        {
            SessionNotes.Add(note);
        }
        public string Recall()
        {
            return SessionNotes.Count > 0 ? string.Join("\n", SessionNotes) : "No notes remembered yet.";
        }
    }
}
