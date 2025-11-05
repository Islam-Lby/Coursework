namespace Coursework
{
    partial class btnSubmitQuiz
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblQuestionNo = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnReviewFlaggedQuestions = new System.Windows.Forms.Button();
            this.btnReviewNext = new System.Windows.Forms.Button();
            this.btnReviewPrevious = new System.Windows.Forms.Button();
            this.QuizTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(124, 63);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(44, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Location = new System.Drawing.Point(127, 99);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(103, 20);
            this.rbOptionA.TabIndex = 1;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "radioButton1";
            this.rbOptionA.UseVisualStyleBackColor = true;
            this.rbOptionA.CheckedChanged += new System.EventHandler(this.rbOptionA_CheckedChanged);
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Location = new System.Drawing.Point(127, 144);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(103, 20);
            this.rbOptionB.TabIndex = 2;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "radioButton1";
            this.rbOptionB.UseVisualStyleBackColor = true;
            this.rbOptionB.CheckedChanged += new System.EventHandler(this.rbOptionB_CheckedChanged);
            // 
            // rbOptionC
            // 
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Location = new System.Drawing.Point(127, 184);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(103, 20);
            this.rbOptionC.TabIndex = 3;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "radioButton1";
            this.rbOptionC.UseVisualStyleBackColor = true;
            this.rbOptionC.CheckedChanged += new System.EventHandler(this.rbOptionC_CheckedChanged);
            // 
            // rbOptionD
            // 
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Location = new System.Drawing.Point(127, 228);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(103, 20);
            this.rbOptionD.TabIndex = 4;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "radioButton1";
            this.rbOptionD.UseVisualStyleBackColor = true;
            this.rbOptionD.CheckedChanged += new System.EventHandler(this.rbOptionD_CheckedChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(620, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 46);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 329);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 46);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(632, 290);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 16);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "label1";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblQuestionNo
            // 
            this.lblQuestionNo.AutoSize = true;
            this.lblQuestionNo.Location = new System.Drawing.Point(74, 19);
            this.lblQuestionNo.Name = "lblQuestionNo";
            this.lblQuestionNo.Size = new System.Drawing.Size(44, 16);
            this.lblQuestionNo.TabIndex = 8;
            this.lblQuestionNo.Text = "label1";
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Location = new System.Drawing.Point(22, 253);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(44, 16);
            this.lblTopic.TabIndex = 9;
            this.lblTopic.Text = "label1";
            this.lblTopic.Click += new System.EventHandler(this.lblTopic_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(620, 395);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 32);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit Quiz";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(22, 290);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(44, 16);
            this.lblDifficulty.TabIndex = 11;
            this.lblDifficulty.Text = "label1";
            this.lblDifficulty.Click += new System.EventHandler(this.lblDifficulty_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(625, 19);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(106, 39);
            this.btnFlag.TabIndex = 12;
            this.btnFlag.Text = "Flag Question";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnReviewFlaggedQuestions
            // 
            this.btnReviewFlaggedQuestions.Location = new System.Drawing.Point(466, 388);
            this.btnReviewFlaggedQuestions.Name = "btnReviewFlaggedQuestions";
            this.btnReviewFlaggedQuestions.Size = new System.Drawing.Size(129, 46);
            this.btnReviewFlaggedQuestions.TabIndex = 13;
            this.btnReviewFlaggedQuestions.Text = "Review Flagged Questions";
            this.btnReviewFlaggedQuestions.UseVisualStyleBackColor = true;
            this.btnReviewFlaggedQuestions.Click += new System.EventHandler(this.btnReviewFlaggedQuestions_Click);
            // 
            // btnReviewNext
            // 
            this.btnReviewNext.Location = new System.Drawing.Point(484, 329);
            this.btnReviewNext.Name = "btnReviewNext";
            this.btnReviewNext.Size = new System.Drawing.Size(111, 46);
            this.btnReviewNext.TabIndex = 14;
            this.btnReviewNext.Text = "Next";
            this.btnReviewNext.UseVisualStyleBackColor = true;
            this.btnReviewNext.Click += new System.EventHandler(this.btnReviewNext_Click);
            // 
            // btnReviewPrevious
            // 
            this.btnReviewPrevious.Location = new System.Drawing.Point(136, 329);
            this.btnReviewPrevious.Name = "btnReviewPrevious";
            this.btnReviewPrevious.Size = new System.Drawing.Size(105, 46);
            this.btnReviewPrevious.TabIndex = 15;
            this.btnReviewPrevious.Text = "Previous";
            this.btnReviewPrevious.UseVisualStyleBackColor = true;
            this.btnReviewPrevious.Click += new System.EventHandler(this.btnReviewPrevious_Click);
            // 
            // QuizTimer
            // 
            this.QuizTimer.Tick += new System.EventHandler(this.QuizTimer_Tick);
            // 
            // btnSubmitQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReviewPrevious);
            this.Controls.Add(this.btnReviewNext);
            this.Controls.Add(this.btnReviewFlaggedQuestions);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblQuestionNo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbOptionD);
            this.Controls.Add(this.rbOptionC);
            this.Controls.Add(this.rbOptionB);
            this.Controls.Add(this.rbOptionA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "btnSubmitQuiz";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblQuestionNo;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnReviewFlaggedQuestions;
        private System.Windows.Forms.Button btnReviewNext;
        private System.Windows.Forms.Button btnReviewPrevious;
        private System.Windows.Forms.Timer QuizTimer;
    }
}