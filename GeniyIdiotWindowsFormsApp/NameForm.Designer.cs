namespace GeniyIdiotWindowsFormsApp
{
    partial class NameForm
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
            this.requestNameTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.acceptNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // requestNameTextLabel
            // 
            this.requestNameTextLabel.AutoSize = true;
            this.requestNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.requestNameTextLabel.Location = new System.Drawing.Point(5, 29);
            this.requestNameTextLabel.Name = "requestNameTextLabel";
            this.requestNameTextLabel.Size = new System.Drawing.Size(245, 16);
            this.requestNameTextLabel.TabIndex = 0;
            this.requestNameTextLabel.Text = "Пожалуйста, введите ваше имя:";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(8, 58);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(242, 20);
            this.userAnswerTextBox.TabIndex = 1;
            this.userAnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userAnswerTextBox_KeyPress);
            // 
            // acceptNameButton
            // 
            this.acceptNameButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptNameButton.Location = new System.Drawing.Point(94, 137);
            this.acceptNameButton.Name = "acceptNameButton";
            this.acceptNameButton.Size = new System.Drawing.Size(84, 54);
            this.acceptNameButton.TabIndex = 2;
            this.acceptNameButton.Text = "ОК";
            this.acceptNameButton.UseVisualStyleBackColor = true;
            this.acceptNameButton.Click += new System.EventHandler(this.acceptNameButton_Click);
            // 
            // NameForm
            // 
            this.AcceptButton = this.acceptNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 217);
            this.Controls.Add(this.acceptNameButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.requestNameTextLabel);
            this.Name = "NameForm";
            this.Text = "Имя пользователя";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestNameTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button acceptNameButton;
    }
}