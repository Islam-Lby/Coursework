using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class ReviewAnswersForm : Form
    {
        private List<Question> questions;
        private string[] userAns;
        private int currentQindex = 0;
        


        public ReviewAnswersForm(List<Question> questions, string[] userAns)
        {
            InitializeComponent();
            this.questions = questions;
            this.userAns = userAns;
            DisplayCurrentQuestion();
        }
        private void DisplayCurrentQuestion()
        {
            if (currentQindex >= 0 && currentQindex < questions.Count)
            {

                Question Q = questions[currentQindex];
                lblQuestion.Text = Q.GetText();
                string[] currentOptions = Q.GetOptions();
                rbOptionA.Text = currentOptions[0];
                rbOptionB.Text = currentOptions[1];
                rbOptionC.Text = currentOptions[2];
                rbOptionD.Text = currentOptions[3];
                rbOptionA.Enabled = false;
                rbOptionB.Enabled = false;
                rbOptionC.Enabled = false;
                rbOptionD.Enabled = false;
                lblUserAnswer.ForeColor = Color.Red;
                lblCorrectAns.ForeColor = Color.Green;
                string userAnswer = this.userAns[currentQindex];
                if (string.IsNullOrEmpty(userAnswer))
                {
                    lblUserAnswer.Text = $"Your Answer: [No Answer]";
                }
                else { lblUserAnswer.Text = "Your Answer: " + userAnswer; }
                string correctAns = Q.GetAnswer();
                lblCorrectAns.Text = $"Correct Answer: {correctAns}";
                if (!string.IsNullOrEmpty(userAnswer))
                {
                    if (userAnswer == rbOptionA.Text)
                    {
                        rbOptionA.ForeColor = Color.Red;

                    }
                    else if (userAnswer == rbOptionB.Text)
                    {
                        rbOptionB.ForeColor = Color.Red;


                    }
                    else if (userAnswer == rbOptionC.Text)
                    {
                        rbOptionC.ForeColor = Color.Red;

                    }
                    else if (userAnswer == rbOptionD.Text)
                    {
                        rbOptionD.ForeColor = Color.Red;

                    }
                }
                    if (correctAns == rbOptionA.Text)
                    {
                        rbOptionA.ForeColor = Color.Green;
                    }
                    else if (correctAns == rbOptionB.Text)
                    {
                        rbOptionB.ForeColor = Color.Green;
                    }
                    else if (correctAns == rbOptionC.Text)
                    {
                        rbOptionC.ForeColor = Color.Green;
                    }
                    else if (correctAns == rbOptionD.Text)
                    {
                        rbOptionD.ForeColor = Color.Green;
                    }
                if (!string.IsNullOrEmpty(userAnswer) && userAnswer != correctAns)
                {
                    if (userAnswer == rbOptionA.Text)
                        rbOptionA.ForeColor = Color.Red;
                    else if (userAnswer == rbOptionB.Text)
                        rbOptionB.ForeColor = Color.Red;
                    else if (userAnswer == rbOptionC.Text)
                        rbOptionC.ForeColor = Color.Red;
                    else if (userAnswer == rbOptionD.Text)
                        rbOptionD.ForeColor = Color.Red;
                }
                if (currentQindex == 0)
                {
                    btnPrevious.Visible = false;
                    btnNext.Visible = true;
                }
                else if (currentQindex == questions.Count - 1)
                {
                    btnPrevious.Visible = true;
                    btnNext.Visible = false;
                }
                else
                {
                    btnPrevious.Visible = true;
                    btnNext.Visible = true;
                }

            }
        }

        private void ReviewAnswersForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue;
            lblQuestion.ForeColor = System.Drawing.Color.White;
            rbOptionA.ForeColor = System.Drawing.Color.White;
            rbOptionB.ForeColor = System.Drawing.Color.White;
            rbOptionC.ForeColor = System.Drawing.Color.White;
            rbOptionD.ForeColor = System.Drawing.Color.White;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentQindex--;
            ResetColours();
            DisplayCurrentQuestion();

        }
        private void ResetColours()
        {
            rbOptionA.ForeColor = SystemColors.ControlText;
            rbOptionB.ForeColor = SystemColors.ControlText;
            rbOptionC.ForeColor = SystemColors.ControlText;
            rbOptionD.ForeColor = SystemColors.ControlText;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQindex++;
            ResetColours();
            DisplayCurrentQuestion();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            leaderBoardForm lbForm = new leaderBoardForm();
            lbForm.Show();
            this.Hide();

        }

        private void lblUserAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
