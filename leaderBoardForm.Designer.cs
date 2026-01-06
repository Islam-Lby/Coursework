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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.labelLbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEndQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // lstScores
            // 
            this.lstScores.FormattingEnabled = true;
            this.lstScores.ItemHeight = 16;
            this.lstScores.Location = new System.Drawing.Point(109, 150);
            this.lstScores.Name = "lstScores";
            this.lstScores.Size = new System.Drawing.Size(443, 372);
            this.lstScores.TabIndex = 0;
            // 
            // labelLbTitle
            // 
            this.labelLbTitle.AutoSize = true;
            this.labelLbTitle.Font = new System.Drawing.Font("Script MT Bold", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLbTitle.Location = new System.Drawing.Point(197, 46);
            this.labelLbTitle.Name = "labelLbTitle";
            this.labelLbTitle.Size = new System.Drawing.Size(233, 51);
            this.labelLbTitle.TabIndex = 1;
            this.labelLbTitle.Text = "Leaderboard";
            this.labelLbTitle.Click += new System.EventHandler(this.labelLbTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your progress";
            // 
            // chartProgress
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProgress.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProgress.Legends.Add(legend2);
            this.chartProgress.Location = new System.Drawing.Point(688, 150);
            this.chartProgress.Name = "chartProgress";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProgress.Series.Add(series2);
            this.chartProgress.Size = new System.Drawing.Size(511, 366);
            this.chartProgress.TabIndex = 3;
            this.chartProgress.Text = "chart1";
            // 
            // btnEndQuiz
            // 
            this.btnEndQuiz.Location = new System.Drawing.Point(1085, 548);
            this.btnEndQuiz.Name = "btnEndQuiz";
            this.btnEndQuiz.Size = new System.Drawing.Size(159, 37);
            this.btnEndQuiz.TabIndex = 4;
            this.btnEndQuiz.Text = "End Quiz";
            this.btnEndQuiz.UseVisualStyleBackColor = true;
            this.btnEndQuiz.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaderBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 597);
            this.Controls.Add(this.btnEndQuiz);
            this.Controls.Add(this.chartProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLbTitle);
            this.Controls.Add(this.lstScores);
            this.Name = "leaderBoardForm";
            this.Text = "leaderBoardForm";
            this.Load += new System.EventHandler(this.leaderBoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Label labelLbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
        private System.Windows.Forms.Button btnEndQuiz;
    }
}