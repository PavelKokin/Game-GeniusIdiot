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
    public partial class ResultTableForm : Form
    {
        public ResultTableForm()
        {
            InitializeComponent();
        }

        private void ResultTableForm_Load(object sender, EventArgs e)
        {
            var users = UserResultStorage.GetAll();
            foreach (var user in users)
            {
                resultsTableDataGridView.Rows.Add(user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }

        private void resultsTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultTableForm_Leave(object sender, EventArgs e)
        {
            resultsTableDataGridView.ClearSelection();
        }
    }
}
