using System;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class mainForm : Form
    {
        private Game game;
        public User user;
        public Question newQuestion;
        private int timeQuestion = 10;
        public mainForm()
        {
            InitializeComponent();
            questionNumberLabel.Visible = false;
            questionTextLabel.Visible = false;
            userAnswerTextBox.Visible = false;
            nextQuestionButton.Visible = false;
            timeTextLabel.Visible = false;
            timeCountLabel.Visible = false;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        private void ShowNextQuestion()
        {
            userAnswerTextBox.Focus();
            var currentQuestion = game.PopRandomQuestion();
            questionNumberLabel.Text = game.GetQuestionNumberInfo();
            questionTextLabel.Text = currentQuestion.Text;
            timeQuestion = 10;
        }
        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            game.AcceptUserAnswer(userAnswer);
            if (game.End())
            {
                EndGame();
                return;

            }
            userAnswerTextBox.Text = null;
            ShowNextQuestion();
        }
        private void EndGame()
        {
            questionTimer.Enabled = false;
            MessageBox.Show(game.DiagnoseCalculate() + "\nКоличество правильных ответов: " + user.CountRightAnswers);
            UserResultStorage.Append(user);
            nextQuestionButton.Enabled = false;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameToolStripMenuItem.Enabled = false;
            user = new User("");
            var nameForm = new NameForm(user);
            var result = nameForm.ShowDialog(this);
            while (user.Name == "" && result!=DialogResult.Cancel)
            {
                result = nameForm.ShowDialog(this);
            }
            if (result != DialogResult.OK)
            {
                this.Close();
            }
            questionNumberLabel.Visible = true;
            questionTextLabel.Visible = true;
            userAnswerTextBox.Visible = true;
            nextQuestionButton.Visible = true;
            questionTimer.Enabled = true;
            timeTextLabel.Visible = true;
            timeCountLabel.Visible = true;
            game = new Game(user);
            ShowNextQuestion();
        }
        private void userAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < (int)'0' || e.KeyChar > (int)'9'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, вводите только цифры!");
            }
        }
        private void viewResultTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form resultTableForm = new ResultTableForm();
            resultTableForm.ShowDialog(this);
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newQuestion = new Question("Неизвестно", 0);
            QuestionForm questionForm = new QuestionForm(newQuestion);
            questionForm.ShowDialog(this);
        }
        private void questionTimer_Tick(object sender, EventArgs e)
        {
            timeQuestion--;
            timeCountLabel.Text = (timeQuestion.ToString());
            if (timeQuestion == 0 && !game.End())
            {
                ShowNextQuestion();
            }
            if (timeQuestion == 0 && game.End())
            {
                EndGame();
            }
        }

        private void diagnosisStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiagnoseStatisticForm diagnoseStatisticForm = new DiagnoseStatisticForm();
            diagnoseStatisticForm.ShowDialog(this);
        }
    }
}
