using GeniyIdiotClassLibrary;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class DiagnoseStatisticForm : Form
    {
        public DiagnoseStatisticForm()
        {
            InitializeComponent();
        }
        private void DiagnoseStatisticForm_Load(object sender, EventArgs e)
        {
            var users = UserResultStorage.GetAll();
            var diagnoses = DiagnoseCalculator.GetDiagnosis();
            for (int i=0; i<diagnoses.Count;i++)
            {
                int count = 0;
                foreach (var user in users)
                {
                    if (user.Diagnose == diagnoses[i].Name)
                    {
                        count++;
                    }
                }
                diagnosesTableDataGridView.Rows.Add(diagnoses[i].Name, count);
            }
        }
    }
}
