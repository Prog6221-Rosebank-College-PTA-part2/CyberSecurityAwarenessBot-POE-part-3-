using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatbotApp_
{
    public class QuizForm : Form
    {
        private Label lblQuestion;
        private RadioButton[] options;
        private Button btnNext;

        private int currentQuestion = 0;
        private int score = 0;

        public QuizForm()
        {
            BuildUI();

            ActivityLog.AddLog("Quiz Started");

            LoadQuestion();
        }

        private void BuildUI()
        {
            Text = "Cybersecurity Quiz";
            Size = new Size(700, 400);
            StartPosition = FormStartPosition.CenterScreen;

            lblQuestion = new Label()
            {
                Location = new Point(20, 20),
                Width = 620,
                Height = 60,
                Font = new Font(
                    "Segoe UI",
                    12,
                    FontStyle.Bold)
            };

            options = new RadioButton[4];

            for (int i = 0; i < 4; i++)
            {
                options[i] = new RadioButton()
                {
                    Location =
                        new Point(40, 100 + (i * 40)),
                    Width = 500
                };

                Controls.Add(options[i]);
            }

            btnNext = new Button()
            {
                Text = "Next",
                Width = 120,
                Location = new Point(40, 280)
            };

            btnNext.Click += BtnNext_Click;

            Controls.Add(lblQuestion);
            Controls.Add(btnNext);
        }

        private void LoadQuestion()
        {
            if (currentQuestion >= QuizManager.Questions.Count)
            {
                FinishQuiz();
                return;
            }

            QuizQuestion q =
                QuizManager.Questions[currentQuestion];

            lblQuestion.Text =
                q.Question;

            for (int i = 0; i < 4; i++)
            {
                options[i].Text =
                    q.Answers[i];

                options[i].Checked = false;
            }
        }

        private void BtnNext_Click(
            object sender,
            EventArgs e)
        {
            QuizQuestion q =
                QuizManager.Questions[currentQuestion];

            for (int i = 0; i < 4; i++)
            {
                if (options[i].Checked)
                {
                    if (i == q.CorrectAnswer)
                    {
                        score++;
                    }
                }
            }

            currentQuestion++;

            LoadQuestion();
        }

        private void FinishQuiz()
        {
            ActivityLog.AddLog(
                $"Quiz Completed. Score: {score}");

            MessageBox.Show(
                $"Quiz Complete!\n\nScore: {score}/{QuizManager.Questions.Count}");

            Close();
        }
    }
}