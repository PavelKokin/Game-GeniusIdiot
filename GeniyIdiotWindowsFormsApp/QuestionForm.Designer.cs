namespace GeniyIdiotWindowsFormsApp
{
    partial class QuestionForm
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
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userQuestionTextBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.answerUserQuestionTextBox = new System.Windows.Forms.TextBox();
            this.acceptQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(13, 37);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(91, 13);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Введите вопрос:";
            // 
            // userQuestionTextBox
            // 
            this.userQuestionTextBox.Location = new System.Drawing.Point(16, 79);
            this.userQuestionTextBox.Name = "userQuestionTextBox";
            this.userQuestionTextBox.Size = new System.Drawing.Size(100, 20);
            this.userQuestionTextBox.TabIndex = 1;
            this.userQuestionTextBox.TextChanged += new System.EventHandler(this.userQuestionTextBox_TextChanged);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(16, 127);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(83, 13);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.Text = "Введите ответ:";
            // 
            // answerUserQuestionTextBox
            // 
            this.answerUserQuestionTextBox.Location = new System.Drawing.Point(16, 170);
            this.answerUserQuestionTextBox.Name = "answerUserQuestionTextBox";
            this.answerUserQuestionTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerUserQuestionTextBox.TabIndex = 3;
            this.answerUserQuestionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerUserQuestionTextBox_KeyPress);
            // 
            // acceptQuestionButton
            // 
            this.acceptQuestionButton.Location = new System.Drawing.Point(16, 233);
            this.acceptQuestionButton.Name = "acceptQuestionButton";
            this.acceptQuestionButton.Size = new System.Drawing.Size(100, 32);
            this.acceptQuestionButton.TabIndex = 4;
            this.acceptQuestionButton.Text = "Принять";
            this.acceptQuestionButton.UseVisualStyleBackColor = true;
            this.acceptQuestionButton.Click += new System.EventHandler(this.acceptQuestionButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 306);
            this.Controls.Add(this.acceptQuestionButton);
            this.Controls.Add(this.answerUserQuestionTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.userQuestionTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Name = "QuestionForm";
            this.Text = "Ввод пользовательского вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox userQuestionTextBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox answerUserQuestionTextBox;
        private System.Windows.Forms.Button acceptQuestionButton;
    }
}