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
            this.labelLbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 16;
            this.lstScores.Location = new System.Drawing.Point(201, 154);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(344, 164);
            this.lstScores.TabIndex = 0;
            // 
            // labelLbTitle
            // 
            this.labelLbTitle.AutoSize = true;
            this.labelLbTitle.Font = new System.Drawing.Font("Script MT Bold", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLbTitle.Location = new System.Drawing.Point(249, 57);
            this.labelLbTitle.Name = "labelLbTitle";
            this.labelLbTitle.Size = new System.Drawing.Size(233, 51);
            this.labelLbTitle.TabIndex = 1;
            this.labelLbTitle.Text = "Leaderboard";
            // 
            // leaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLbTitle);
            this.Controls.Add(this.lstScores);
            this.Name = "leaderBoardForm";
            this.Text = "leaderBoardForm";
            this.Load += new System.EventHandler(this.leaderBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Label labelLbTitle;
    }
}