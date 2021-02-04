namespace GeniyIdiotWindowsFormsApp
{
    partial class DiagnoseStatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.diagnosesTableDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDiagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosesTableDataGridView
            // 
            this.diagnosesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosesTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDiagnose,
            this.diagnoseCountColumn});
            this.diagnosesTableDataGridView.Location = new System.Drawing.Point(12, 12);
            this.diagnosesTableDataGridView.Name = "diagnosesTableDataGridView";
            this.diagnosesTableDataGridView.Size = new System.Drawing.Size(243, 426);
            this.diagnosesTableDataGridView.TabIndex = 0;
            // 
            // nameDiagnose
            // 
            this.nameDiagnose.HeaderText = "Диагноз";
            this.nameDiagnose.Name = "nameDiagnose";
            // 
            // diagnoseCountColumn
            // 
            this.diagnoseCountColumn.HeaderText = "Кол-во поставленных диагнозов";
            this.diagnoseCountColumn.Name = "diagnoseCountColumn";
            // 
            // DiagnoseStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.diagnosesTableDataGridView);
            this.Name = "DiagnoseStatisticForm";
            this.Text = "DiagnoseStatisticForm";
            this.Load += new System.EventHandler(this.DiagnoseStatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView diagnosesTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDiagnose;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnoseCountColumn;
    }
}