using System.Media;

namespace CybersecurityChatbot
{
    public partial class MainForm : Form
    {
        private readonly ChatbotEngine chatbotEngine;

        public MainForm()
        {
            InitializeComponent();
            WireEvents();
            PlayVoiceGreeting();
            ShowWelcome();
            chatbotEngine = new ChatbotEngine();
        }

        private void WireEvents()
        {
            btnSend.Click += BtnSend_Click;
            txtInput.KeyDown += TxtInput_KeyDown;
            btnClear.Click += BtnClear_Click;
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BtnSend_Click(this, EventArgs.Empty);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
            ;

            private void PlayVoiceGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav");
                if (File.Exists(path))
                    using (var player = new SoundPlayer(path))
                    {
                        player.PlaySync();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not play voice greeting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            private void ShowWelcome()
        {
            AppendBotMessage("Welcome to the Cybersecurity Awareness Bot!", Sentiment.Neutral);
            AppendBotMessage("I can help you with: password security, phishing awareness, and safe browsing tips.", Sentiment.Neutral);
            AppendBotMessage("You can also tell me your name" + "and I'll remember it", Sentiment.Neutral);
            AppendDivider();
        }

        private void SendMessage()
        {
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput))
                return;

            AppendUserMessage(userInput);
            txtInput.Clear();

            var (response, sentiment) = chatbotEngine.ProcessInput(userInput);
            AppendBotMessage(response, sentiment);
            UpdateStatusBar(sentiment);
            AppendDivider();
        }

        //Chat display methods
        private void AppendUserMessage(string message)
        {
            rtbChat.SelectStart(rtbChat.TextLength, 0);

            rtbChat.SelectionColor = Color.FromArgb(148, 163, 184);
            rtbChat.SelectionFont = new Font("Segoe UI", 10f, FontStyle.Bold);
            rtbChat.AppendText($"You: {text}\n");

        }

        private void AppendBotMessage(string message, Sentiment sentiment)
        {
            rtbChat.SelectStart(rtbChat.TextLength, 0);
            Color sentimentColor = sentiment switch
            {
                Sentiment.Worried => Color.FromArgb(251, 191, 37),
                sentiment.Curious => Color.FromArgb(74, 222, 128),
                Sentiment.Frestrated => Color.FromArgb(248, 113, 113),
                _ => Color.FromArgb(13, 148, 136)
            };
            rtbChat.SelectionColor = sentimentColor;
            rtbChat.SelectionFont = new Font("Segoe UI", 10f, FontStyle.Bold);
            rtbChat.AppendText($"Bot: {message}\n");

            rtbChat.SelectStart(rtbChat.TextLength, 0);
            rtbChat.SelectionColor = Color.FromArgb(226, 232, 240);
            rtbChat.AppendText($"[{text}]\n");

            rtbChat.ScrollToCaret();
        }

        private void AppendDivider()
        {

            rtbChat.SelectionColor = Color.FromArgb(51, 65, 85);
            rtbChat.AppendText(" " + new string('-', 55) + "\n");

        }
        private void UpdateStatusBar(Sentiment sentiment)
        {
            (string sentimentText, Color sentimentColor) = sentiment switch
            {
                Sentiment.Worried => ("Worried", Color.FromArgb(251, 191, 36)),
                Sentiment.Curious => ("Curious", Color.FromArgb(74, 222, 128)),
                Sentiment.Frestrated => ("Frustrated", Color.FromArgb(248, 113, 113)),
                _ => ("Neutral", Color.FromArgb(148, 210, 189))
            };

            lblSentiment.Text = $"Sentiment: {sentimentText}";
            lblSentiment.ForeColor = sentimentColor;

            // Update memory status
            string memoryStatus = chatbotEngine.MemoryStore.UserName != null ? $"Name stored: {chatbotEngine.MemoryStore.UserName}" : "Memory: No name stored yet";
        }
    }
