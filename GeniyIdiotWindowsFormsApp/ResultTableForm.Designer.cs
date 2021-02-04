namespace GeniyIdiotWindowsFormsApp
{
    partial class ResultTableForm
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
            this.resultsTableDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCountRightAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDiagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsTableDataGridView
            // 
            this.resultsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.userCountRightAnswerColumn,
            this.userDiagnoseColumn});
            this.resultsTableDataGridView.Location = new System.Drawing.Point(12, 12);
            this.resultsTableDataGridView.Name = "resultsTableDataGridView";
            this.resultsTableDataGridView.Size = new System.Drawing.Size(505, 242);
            this.resultsTableDataGridView.TabIndex = 0;
            this.resultsTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsTableDataGridView_CellContentClick);
            // 
            // userNameColumn
            // 
            this.userNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userNameColumn.HeaderText = "ФИО";
            this.userNameColumn.MinimumWidth = 200;
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.Width = 200;
            // 
            // userCountRightAnswerColumn
            // 
            this.userCountRightAnswerColumn.HeaderText = "Кол-во правильных ответов";
            this.userCountRightAnswerColumn.Name = "userCountRightAnswerColumn";
            // 
            // userDiagnoseColumn
            // 
            this.userDiagnoseColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userDiagnoseColumn.HeaderText = "Диагноз";
            this.userDiagnoseColumn.MinimumWidth = 100;
            this.userDiagnoseColumn.Name = "userDiagnoseColumn";
            // 
            // ResultTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 259);
            this.Controls.Add(this.resultsTableDataGridView);
            this.Name = "ResultTableForm";
            this.Text = "Результаты игр";
            this.Load += new System.EventHandler(this.ResultTableForm_Load);
            this.Leave += new System.EventHandler(this.ResultTableForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.resultsTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCountRightAnswerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDiagnoseColumn;
    }
}