namespace Coursework
{
    partial class leaderBoardForm
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
            this.lstScores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 16;
            this.lstScores.Location = new System.Drawing.Point(181, 92);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(344, 164);
            this.lstScores.TabIndex = 0;
            // 
            // leaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstScores);
            this.Name = "leaderBoardForm";
            this.Text = "leaderBoardForm";
            this.Load += new System.EventHandler(this.leaderBoardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstScores;
    }
}