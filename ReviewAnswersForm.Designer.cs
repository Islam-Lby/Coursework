namespace Coursework
{
    partial class ReviewAnswersForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.lblUserAnswer = new System.Windows.Forms.Label();
            this.lblCorrectAns = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(125, 47);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(44, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(128, 104);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(103, 20);
            this.rbOptionA.TabIndex = 1;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "radioButton1";
            this.rbOptionA.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(128, 162);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(103, 20);
            this.rbOptionB.TabIndex = 2;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "radioButton1";
            this.rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Location = new System.Drawing.Point(128, 219);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(103, 20);
            this.rbOptionC.TabIndex = 3;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "radioButton1";
            this.rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionD
            // 
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Location = new System.Drawing.Point(128, 268);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(103, 20);
            this.rbOptionD.TabIndex = 4;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "radioButton1";
            this.rbOptionD.UseVisualStyleBackColor = true;
            // 
            // lblUserAnswer
            // 
            this.lblUserAnswer.AutoSize = true;
            this.lblUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAnswer.Location = new System.Drawing.Point(499, 106);
            this.lblUserAnswer.Name = "lblUserAnswer";
            this.lblUserAnswer.Size = new System.Drawing.Size(41, 15);
            this.lblUserAnswer.TabIndex = 5;
            this.lblUserAnswer.Text = "label2";
            this.lblUserAnswer.Click += new System.EventHandler(this.lblUserAnswer_Click);
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = true;
            this.lblCorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAns.Location = new System.Drawing.Point(499, 250);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.Size = new System.Drawing.Size(41, 15);
            this.lblCorrectAns.TabIndex = 6;
            this.lblCorrectAns.Text = "label1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 322);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(102, 65);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(883, 322);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(106, 65);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(877, 405);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 33);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.Text = "Finish review";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // ReviewAnswersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblCorrectAns);
            this.Controls.Add(this.lblUserAnswer);
            this.Controls.Add(this.rbOptionD);
            this.Controls.Add(this.rbOptionC);
            this.Controls.Add(this.rbOptionB);
            this.Controls.Add(this.rbOptionA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "ReviewAnswersForm";
            this.Text = "ReviewAnswersForm";
            this.Load += new System.EventHandler(this.ReviewAnswersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Label lblUserAnswer;
        private System.Windows.Forms.Label lblCorrectAns;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinish;
    }
}