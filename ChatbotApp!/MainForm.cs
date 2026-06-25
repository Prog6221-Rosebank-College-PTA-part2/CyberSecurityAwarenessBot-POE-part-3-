/*using ChatbotApp;
using ChatbotApp_;
using System;

QuizForm quiz = new QuizForm();
quiz.ShowDialog();*/
using ChatbotApp_;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatbotApp_
{
    public class MainForm : Form
    {
        private RichTextBox chatBox;
        private TextBox inputBox;
        private Button sendButton;
        private Button taskButton;
        private Button quizButton;

        public MainForm()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "Cybersecurity Awareness Bot";
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;

            chatBox = new RichTextBox
            {
                Location = new Point(10, 10),
                Width = 760,
                Height = 400,
                ReadOnly = true
            };

            inputBox = new TextBox
            {
                Location = new Point(10, 430),
                Width = 600
            };

            sendButton = new Button
            {
                Text = "Send",
                Location = new Point(620, 428),
                Width = 150
            };

            sendButton.Click += SendButton_Click;

            taskButton = new Button
            {
                Text = "Tasks",
                Location = new Point(10, 480),
                Width = 150
            };

            taskButton.Click += TaskButton_Click;

            quizButton = new Button
            {
                Text = "Quiz",
                Location = new Point(180, 480),
                Width = 150
            };

            quizButton.Click += QuizButton_Click;

            Controls.Add(chatBox);
            Controls.Add(inputBox);
            Controls.Add(sendButton);
            Controls.Add(taskButton);
            Controls.Add(quizButton);

            chatBox.AppendText(
                "🤖 Welcome to the Cybersecurity Awareness Bot!\n" +
                "Ask me about passwords, phishing, malware, safe browsing or type:\n" +
                "'show activity log'\n\n");
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string input = inputBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(
                    "Please enter a message.");
                return;
            }

            chatBox.AppendText(
                "You: " + input + Environment.NewLine);

            string response =
                ResponseEngine.GetResponse(input);

            chatBox.AppendText(
                "Bot: " + response +
                Environment.NewLine +
                Environment.NewLine);

            ActivityLog.AddLog(
                $"User asked: {input}");

            inputBox.Clear();
        }

        private void TaskButton_Click(
            object sender,
            EventArgs e)
        {
            TaskForm form = new TaskForm();
            form.ShowDialog();
        }

        private void QuizButton_Click(
            object sender,
            EventArgs e)
        {
            QuizForm form = new QuizForm();
            form.ShowDialog();
        }
    }
}
