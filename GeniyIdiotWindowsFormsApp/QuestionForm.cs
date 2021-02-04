using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionForm : Form
    {
        Question newQuestion;
        public QuestionForm(Question newQuestion)
        {
            InitializeComponent();
            this.newQuestion = newQuestion;
        }

        private void userQuestionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void acceptQuestionButton_Click(object sender, EventArgs e)
        {
            newQuestion.Text = userQuestionTextBox.Text;
            newQuestion.Answer = Convert.ToInt32(answerUserQuestionTextBox.Text);
            QuestionsStorage.Add(newQuestion);
            Close();
        }

        private void answerUserQuestionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < (int) '0' || e.KeyChar > (int) '9'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, вводите только цифры!");
            }
        }
    }
}
