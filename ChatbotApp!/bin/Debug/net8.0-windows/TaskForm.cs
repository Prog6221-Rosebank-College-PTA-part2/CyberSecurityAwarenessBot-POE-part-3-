using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChatbotApp_
{
    public class TaskForm : Form
    {
        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dtReminder;
        private Button btnAdd;
        private Button btnView;
        private RichTextBox outputBox;

        public TaskForm()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "Task Assistant";
            Size = new Size(600, 500);
            StartPosition = FormStartPosition.CenterScreen;

            Label lblTitle = new Label()
            {
                Text = "Task Title",
                Location = new Point(20, 20)
            };

            txtTitle = new TextBox()
            {
                Location = new Point(20, 45),
                Width = 250
            };

            Label lblDesc = new Label()
            {
                Text = "Description",
                Location = new Point(20, 80)
            };

            txtDescription = new TextBox()
            {
                Location = new Point(20, 105),
                Width = 250
            };

            Label lblDate = new Label()
            {
                Text = "Reminder Date",
                Location = new Point(20, 140)
            };

            dtReminder = new DateTimePicker()
            {
                Location = new Point(20, 165),
                Width = 250
            };

            btnAdd = new Button()
            {
                Text = "Add Task",
                Location = new Point(20, 210),
                Width = 120
            };

            btnAdd.Click += BtnAdd_Click;

            btnView = new Button()
            {
                Text = "View Tasks",
                Location = new Point(150, 210),
                Width = 120
            };

            btnView.Click += BtnView_Click;

            outputBox = new RichTextBox()
            {
                Location = new Point(20, 260),
                Width = 540,
                Height = 170,
                ReadOnly = true
            };

            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblDesc);
            Controls.Add(txtDescription);
            Controls.Add(lblDate);
            Controls.Add(dtReminder);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(outputBox);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TaskManager.AddTask(
                txtTitle.Text,
                txtDescription.Text,
                dtReminder.Value);

            MessageBox.Show(
                "Task added successfully!");

            txtTitle.Clear();
            txtDescription.Clear();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            outputBox.Text =
                TaskManager.ViewTasks();
        }
    }
}