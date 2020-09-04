namespace RandomAn
{
    partial class Form1
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
            this.Txt_Question = new System.Windows.Forms.TextBox();
            this.Txt_Answer = new System.Windows.Forms.TextBox();
            this.BtnGetAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Question
            // 
            this.Txt_Question.Location = new System.Drawing.Point(157, 94);
            this.Txt_Question.Multiline = true;
            this.Txt_Question.Name = "Txt_Question";
            this.Txt_Question.Size = new System.Drawing.Size(681, 115);
            this.Txt_Question.TabIndex = 0;
            // 
            // Txt_Answer
            // 
            this.Txt_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Answer.Location = new System.Drawing.Point(481, 266);
            this.Txt_Answer.Name = "Txt_Answer";
            this.Txt_Answer.Size = new System.Drawing.Size(357, 39);
            this.Txt_Answer.TabIndex = 1;
            // 
            // BtnGetAnswer
            // 
            this.BtnGetAnswer.Location = new System.Drawing.Point(891, 137);
            this.BtnGetAnswer.Name = "BtnGetAnswer";
            this.BtnGetAnswer.Size = new System.Drawing.Size(142, 72);
            this.BtnGetAnswer.TabIndex = 2;
            this.BtnGetAnswer.Text = "Get Answer";
            this.BtnGetAnswer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 553);
            this.Controls.Add(this.BtnGetAnswer);
            this.Controls.Add(this.Txt_Answer);
            this.Controls.Add(this.Txt_Question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Question;
        private System.Windows.Forms.TextBox Txt_Answer;
        private System.Windows.Forms.Button BtnGetAnswer;
    }
}

