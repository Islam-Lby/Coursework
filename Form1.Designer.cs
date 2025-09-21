namespace Coursework
{
    partial class TopicSelectionForm
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
            this.cmbTopics = new System.Windows.Forms.ComboBox();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTopics
            // 
            this.cmbTopics.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTopics.FormattingEnabled = true;
            this.cmbTopics.Location = new System.Drawing.Point(212, 71);
            this.cmbTopics.Name = "cmbTopics";
            this.cmbTopics.Size = new System.Drawing.Size(320, 27);
            this.cmbTopics.TabIndex = 1;
            this.cmbTopics.Text = "Choose your Topic";
            this.cmbTopics.SelectedIndexChanged += new System.EventHandler(this.cmbTopics_SelectedIndexChanged);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Location = new System.Drawing.Point(605, 364);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(127, 50);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start the Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // TopicSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTopics);
            this.Controls.Add(this.btnStartQuiz);
            this.Name = "TopicSelectionForm";
            this.Text = "TopicSelectionForm";
            this.Load += new System.EventHandler(this.TopicSelectionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTopics;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}

