using System;

namespace CybersecurityChatbot

{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))

                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "MainForm";
            this.Text = "Cybersecurity Awareness Bot";
            this.ResumeLayout(false);
            this.panelHeader = new Panel();
            this.lblTittle = new Label();
            this.lblSubtittle = new Label();
            this.lblAscii = new Label();
            this.rtbChat = new RichTextBox();
            this.txtInput = new TextBox();
            this.btnSend = new Button();
            this.btnClear = new Button();
            this.panelStatus = new Panel();
            this.lblSentiment = new Label();
            this.lblMemory = new Label();
            this.panelInput = new Panel();

            // panelHeader
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 110;
            this.panelHeader.BackColor = Color.FromArgb(30, 58, 95);
            this.panelHeader.Padding = new Padding(10);

            // lblAscii
            this.lblAscii.Text =
 " ██████╗██╗   ██╗██████╗ ███████╗██████╗ \r\n" +
" ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗ \r\n" +
" ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝ \r\n" +
" ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗ \r\n" +
" ╚██████╗   ██║   ██████╔╝███████╗██║  ██║ \r\n" +
"  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝ \r\n";
            this.lblAscii.Font = new Font("Consolas", 7f, FontStyle.Bold);
            this.lblAscii.ForeColor = Color.FromArgb(74, 222, 128);
            this.lblAscii.AutoSize = true;
            this.lblAscii.Location = new Point(10, 5);

            // lblTittle
            this.lblTittle.Text = "Cybersecurity Awareness Bot";
            this.lblTittle.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            this.lblTittle.ForeColor = Color.White;
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new Point(10, 68);

            // lblSubtittle
            this.lblSubtittle.Text = "Stay Safe. Stay Informed.";
            this.lblSubtittle.Font = new Font("Segoe UI", 9f);
            this.lblSubtittle.ForeColor = Color.FromArgb(148, 210, 189);
            this.lblSubtittle.AutoSize = true;
            this.lblSubtittle.Location = new Point(12, 90);

            this.panelHeader.Controls.Add(lblAscii);
            this.panelHeader.Controls.Add(lblTittle);
            this.panelHeader.Controls.Add(lblSubtittle);

            // rtbChat
            this.rtbChat.BackColor = Color.FromArgb(15, 23, 42);
            this.rtbChat.ForeColor = Color.FromArgb(226, 232, 240);
            this.rtbChat.Font = new Font("Segoe UI", 10f);
            this.rtbChat.Padding = new Padding(8);
            this.rtbChat.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.rtbChat.Dock = DockStyle.Fill;
            this.rtbChat.ReadOnly = true;
            this.rtbChat.BorderStyle = BorderStyle.None;

            // panelStatus
            this.panelStatus.Dock = DockStyle.Bottom;
            this.panelStatus.Height = 30;
            this.panelStatus.BackColor = Color.FromArgb(30, 41, 59);

            this.lblSentiment.Font = new Font("Segoe UI", 9f);
            this.lblSentiment.ForeColor = Color.FromArgb(148, 210, 189);
            this.lblSentiment.AutoSize = true;
            this.lblSentiment.Location = new Point(8, 6);
            this.lblSentiment.Text = "Sentiment: Neutral";

            this.lblMemory.Font = new Font("Segoe UI", 9f);
            this.lblMemory.ForeColor = Color.FromArgb(148, 163, 184);
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new Point(120, 6);
            this.lblMemory.Text = "Memory: No name stored yet";

            this.panelStatus.Controls.Add(lblSentiment);
            this.panelStatus.Controls.Add(lblMemory);

            // panelInput
            this.panelInput.Dock = DockStyle.Bottom;
            this.panelInput.Height = 55;
            this.panelInput.BackColor = Color.FromArgb(30, 41, 59);
            this.panelInput.Padding = new Padding(8, 8, 8, 8);

            // txtInput
            this.txtInput.BackColor = Color.FromArgb(51, 65, 85);
            this.txtInput.ForeColor = Color.White;
            this.txtInput.Font = new Font("Segoe UI", 10f);
            this.txtInput.Location = new Point(8, 12);
            this.txtInput.BorderStyle = BorderStyle.FixedSingle;
            this.txtInput.Size = new Size(480, 30);

            // btnSend
            this.btnSend.Text = "Send";
            this.btnSend.BackColor = Color.FromArgb(13, 148, 136);
            this.btnSend.ForeColor = Color.White;
            this.btnSend.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            this.btnSend.FlatStyle = FlatStyle.Flat;
            this.btnSend.Location = new Point(498, 10);
            this.btnSend.Size = new Size(80, 33);
            this.btnSend.FlatAppearance.BorderSize = 0;

            // btnClear
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = Color.FromArgb(71, 85, 105);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Font = new Font("Segoe UI", 10f);
            this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Location = new Point(588, 10);
            this.btnClear.Size = new Size(70, 33);
            this.btnClear.FlatAppearance.BorderSize = 0;

            this.panelInput.Controls.Add(txtInput);
            this.panelInput.Controls.Add(btnSend);
            this.panelInput.Controls.Add(btnClear);

            // MainForm
            this.Text = "Cybersecurity Awareness Bot";
            this.Size = new Size(800, 600);
            this.MinimumSize = new Size(700, 500);
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9f);

            this.Controls.Add(rtbChat);
            this.Controls.Add(panelInput);
            this.Controls.Add(panelStatus);
            this.Controls.Add(panelHeader);

            components = new System.ComponentModel.Container();
        }

        private Panel panelHeader;
        private Label lblTittle;
        private Label lblSubtittle;
        private Label lblAscii;
        private RichTextBox rtbChat;
        private TextBox txtInput;
        private Button btnSend;
        private Button btnClear;
        private Panel panelStatus;
        private Label lblSentiment;
        private Label lblMemory;
        private Panel panelInput;

    }
}
