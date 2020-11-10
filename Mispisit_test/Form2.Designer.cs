namespace Mispisit_test
{
    partial class Form2
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
            this.label_questions = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_questions
            // 
            this.label_questions.Location = new System.Drawing.Point(16, 22);
            this.label_questions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_questions.Name = "label_questions";
            this.label_questions.Size = new System.Drawing.Size(208, 39);
            this.label_questions.TabIndex = 0;
            this.label_questions.Text = "label_question";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 22);
            this.textBox1.TabIndex = 1;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(224, 150);
            this.next_button.Margin = new System.Windows.Forms.Padding(4);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(100, 28);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "Ответить";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AcceptButton = this.next_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 204);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_questions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_questions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label label1;
    }
}