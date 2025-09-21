using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Coursework
{
    public partial class btnSubmitQuiz : Form
    {
        private List<Question> _questions; // variable that holds the filtered list of questions the user will actually see in the quiz
        private string[] _userAnswers; // stores the user answers
        private int _currentIndex; // The index of the question the user is currently on 
        private int _timeLeft =1*60; // how long the user has to complete the quiz
        private int score = 0; // initiaalise score variable to keep track of the score
       private bool quizSubmitted = false; // Tracks whether the user has submitted the quiz
        public btnSubmitQuiz(string topic)
        {

            InitializeComponent();

            
            _questions = LoadQuestionsFromCSV(topic); // the questions that have been loaded from the file based off user preference
            ShuffleQuestions(_questions);
            _userAnswers = new string[_questions.Count];
            _currentIndex = 0;
            DisplayQuestion(_currentIndex); // Displays the question based on the question index
            QuizTimer.Interval = 1000; // the timer decrements by 1 second
            QuizTimer.Start(); // starts the timer
                               // btnSubmitQuiz.Click += btnSubmitQuiz_Click;
           

        }

        public List<Question> LoadQuestionsFromCSV(string topic)
        {
            string line;
            List<Question> questionList = new List<Question>(); // temporary variable used to TEMPORARILY hold ALL questions
                                                                // that are loaded into the CSV file
            try
            {
                StreamReader reader = new StreamReader("MCQ's.csv"); // opens the CSV file

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(','); // splits each line of the file based on the comma
                                      
                    if (values[0] == topic)
                    {
                        string questionText = values[1]; // the question is in the 2nd column of the
                                                         // array 'values', similar to the format of the file 
                        string[] options = new string[4];
                        options[0] = values[2]; // stores 1st option
                        options[1] = values[3]; // stores 2nd option
                        options[2] = values[4]; // stores 3rd option
                        options[3] = values[5]; // stores 4th option
                        string answer = values[6]; // the actual answer to the question is stored in the final column.
                        Question q = new Question(topic, questionText, options, answer); // create a new
                                                                                         // question object that stores the content of
                                                                                         // the CSV file in the same
                                                                                         // format (order) as the CSV file
                        questionList.Add(q); // Adds the question to the list if it is relevant to the selected topic

                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error loading questions"); // if file doesn't exist, this message is output
                Environment.Exit(1); // program stops
            }
            return questionList; // sends the filtered list of questions back to the quiz.
        }
        private void DisplayQuestion(int index)
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
            if (index >= 0 && index < _questions.Count) // checks that the index of the question
                                                        // in the list is within the range of questions
            {
                Question question = _questions[index]; // Get's the current question from the list 
                lblQuestion.Text = question.GetText(); // this label shows the current question
                string[] currentOptions = question.GetOptions(); // get's the answer options 
                
                rbOptionA.Text = currentOptions[0]; // Displays 1st option 
                rbOptionB.Text = currentOptions[1]; // Displays 2nd option 
                rbOptionC.Text =  currentOptions[2]; // Displays 3rd option 
                rbOptionD.Text =  currentOptions[3]; // Displays 4th option 
                lblQuestionNo.Text = $"Question {_currentIndex+1}/{_questions.Count}"; // Number to represent the question
                lblTopic.Text = $"Topic: {question.GetTopic()}"; // Displays the topic the user has chosen. 
                string saved = _userAnswers[index]; // allows the user to change their answers.
                if (saved == currentOptions[0])
                {
                    rbOptionA.Checked = true; // if the user's previous answer was A, select it again
                }
                else if (saved == currentOptions[1])
                {
                    rbOptionB.Checked = true; // if the user's previous answer was B, select it again
                }
                else if (saved == currentOptions[2])
                {
                    rbOptionC.Checked = true; // if the user's previous answer was c, select it again
                }
                else if (saved == currentOptions[3])
                {
                    rbOptionD.Checked = true; //if the user's previous answer was D, select it again
                }
                if ((_currentIndex + 1) < _questions.Count)
                {
                    btnNext.Visible = true; // if the index of the current question is between the 1st question
                                            // and the penultimate question, then the 'next' button is made visible 
                  btnSubmit.Visible = false;
                }
                
                else
                {
                    btnNext.Visible = false; // if not, it is not made visible
                    btnSubmit.Visible = true;   
                }
                if (_currentIndex == 0)
                {
                    btnPrevious.Visible = false; // if the index of the current question is at the
                                                 // start (the user is on the 1st question) then the 'previous' button isn't visible
                    rbOptionA.Checked = false;
                    rbOptionB.Checked = false;
                    rbOptionC.Checked = false;
                    rbOptionD.Checked = false;

                }
                else
                {
                    btnPrevious.Visible = true;

                } // if not (if the user is anywhere between the 2nd question and the last question) then the 'previous' button is made visible
                
                
                
               
                
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveUserAnswer(); // when user moves forward, user answer is saved
            if (_currentIndex < _questions.Count - 1) // if index of the question is in the question list range.
            {
                _currentIndex++; // if user clicks on 'Next button'...
                DisplayQuestion(_currentIndex); //...the next question is displayed
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveUserAnswer(); // when user moves back, user answer is saved
            if (_currentIndex > 0)
            {
                _currentIndex--; // if user clicks on previous button...
                DisplayQuestion(_currentIndex); // ... display the previous question
                
            }
        }
        private void SaveUserAnswer() // saves user answer
        {
            if (rbOptionA.Checked)
            {
                _userAnswers[_currentIndex] = rbOptionA.Text; //if user chooses Option A, program saves user answer as option A
            }
            else if (rbOptionB.Checked)
            {
                _userAnswers[_currentIndex] = rbOptionB.Text;  //if user chooses Option B, program saves user answer as option B

            }
            else if (rbOptionC.Checked)
            {
                _userAnswers[_currentIndex] = rbOptionC.Text;  //if user chooses Option C, program saves user answer as option C
            }
            else if (rbOptionD.Checked)
            {
                _userAnswers[_currentIndex] = rbOptionD.Text;  //if user chooses Option D, program saves user answer as option D

            }
            else
            {
                _userAnswers[_currentIndex] = ""; // if user doesn't choose an option, program
                                                  // saves the answer as an empty string (not answered)

            }
        }

        private void MarkQuiz()
        {
            SaveUserAnswer();
            for (int i = 0; i < _questions.Count; i++) // loops through the quiz
            {
                if (_userAnswers[i] == _questions[i].GetAnswer())
                {
                    score++; // if the user answer is equal to the answer stored in the file, the sccore is incremented
                }
                
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--; // timer counts down
            int mins = _timeLeft / 60; // calculates minutes left
            int secs = _timeLeft % 60; // calculates seconds left
            lblTimer.Text = $"Time left: {mins} mins: {secs} secs"; // displays time left to complete the quiz
            if (_timeLeft <= 0 || quizSubmitted == true)
            {
                
                QuizTimer.Stop(); // when timer hits 0... or if user submits the quiz
                MarkQuiz(); // ... Quiz ie marked
                this.Hide();
                UserNames inputForm = new UserNames();
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string username = inputForm.GetUserNames();
                    SaveResult(username, score); // Save result
                    leaderBoardForm LB_form = new leaderBoardForm();
                    LB_form.Show();
                }


            }
        }

        private void lblTopic_Click(object sender, EventArgs e)
        {

        }

        

        private void QuizForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue;
            lblQuestion.ForeColor = System.Drawing.Color.White;
            rbOptionA.ForeColor = System.Drawing.Color.White;
            rbOptionB.ForeColor = System.Drawing.Color.White;
            rbOptionC.ForeColor = System.Drawing.Color.White;
            rbOptionD.ForeColor = System.Drawing.Color.White;
            lblTimer.ForeColor = System.Drawing.Color.White;
            lblTopic.ForeColor = System.Drawing.Color.White;
            lblQuestionNo.ForeColor = System.Drawing.Color.White;
        }



        private void SaveResult(string username, int score)
        {
            File.AppendAllText("scores.csv", username + "," + score + "\n");
            
        }




        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            quizSubmitted = true;
            SaveUserAnswer();
            MessageBox.Show($"Your score is {score} / {_questions.Count}"); // Outputs the score

            this.Hide(); 
            UserNames inputForm = new UserNames();
            
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                string username = inputForm.GetUserNames();
                SaveResult(username, score);
                leaderBoardForm LB_form = new leaderBoardForm();
                LB_form.Show();
                
                
            }
            else
            {
                MessageBox.Show("Quiz ended.");
            }
        }
        
    private List<Question> ShuffleQuestions(List<Question> questionList1)
    {

        List<Question> shuffledList = new List<Question>();
        Random random = new Random();
        while (questionList1.Count > 0)
        {
            int index = random.Next(questionList1.Count);

           Question selectedQuestion = questionList1[index];

           shuffledList.Add(selectedQuestion);

           questionList1.RemoveAt(index);
        }
        return shuffledList;

}
    }
}
