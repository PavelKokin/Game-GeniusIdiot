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
    public partial class NameForm : Form
    {
        User user;
        private string userInput;
        public NameForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void acceptNameButton_Click(object sender, EventArgs e)
        {
            userInput = userAnswerTextBox.Text;
            if (IsValid(userInput))
            {
                user.Name = userInput;
            }
        }

        private void userAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != (int)' ' && (e.KeyChar < (int)'А' || e.KeyChar > (int)'я'))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, используйте только буквы русского алфавита!");
            }
        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsValid(string userInput)
        {
            if (userInput == "")
            {
                MessageBox.Show("Вы не ввели имя! Повторите ввод");
                return false;
            }
            return true;
        }
    }
}
