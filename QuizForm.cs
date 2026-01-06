using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
        private int _timeLeft = 30 * 60; // how long the user has to complete the quiz
        private int score = 0; // initiaalise score variable to keep track of the score
        private bool quizSubmitted = false; // Tracks whether the user has submitted the quiz
        private List<Question> _flaggedQuestions; // list of questions that ser flags if they are stuck
        private bool[] isFlagged; // checks whether the question has indeed been flagged
        private int _reviewIndex; // reviews 
        private int streak = 0;
        private bool streaktracking = false;
        public btnSubmitQuiz(string topic, string difficulty)
        {

            InitializeComponent();
            _questions = ShuffleQuestions(LoadQuestionsFromCSV(topic, difficulty)); // the questions that have been loaded from the file based off user preferenc
            _userAnswers = new string[_questions.Count];
            _currentIndex = 0;
            _flaggedQuestions = new List<Question>();
            isFlagged = new bool[_questions.Count];
            DisplayQuestion(_currentIndex); // Displays the question based on the question index
            QuizTimer.Interval = 1000; // the timer decrements by 1 second
            QuizTimer.Start(); // starts the timer
        }

        public List<Question> LoadQuestionsFromCSV(string topic, string difficulty)
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
                    string _difficulty = values[0]; // difficulty is stored in the 1st column of the csv file
                    string _topic = values[1]; // the topic is in the 2nd column of the csv file
                    string questionText = values[2]; //the topic is in the 3rd column of the CSV file
                    string[] options = new string[4];
                    options[0] = values[3]; // stores 1st option
                    options[1] = values[4]; // stores 2nd option
                    options[2] = values[5]; // stores 3rd option
                    options[3] = values[6]; // stores 4th option
                    string answer = values[7]; // the actual answer to the question is stored in the final column.
                    if (_difficulty == difficulty && _topic == topic)
                    {
                        Question q = new Question(_difficulty, _topic, questionText, options, answer); // create a new
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
            btnReviewNext.Visible = false;
            btnReviewPrevious.Visible = false;

            

            if (index >= 0 && index < _questions.Count) // checks that the index of the question
                                                        // in the list is within the range of questions
            {

                Question question = _questions[index]; // Get's the current question from the list 
                lblDifficulty.Text = question.GetDifficulty(); // get's the type of difficulty of the question the user is answering
                lblQuestion.Text = question.GetText(); // this label shows the current question
                string[] currentOptions = question.GetOptions(); // get's the answer options 
                rbOptionA.Text = currentOptions[0]; // Displays 1st option 
                rbOptionB.Text = currentOptions[1]; // Displays 2nd option 
                rbOptionC.Text = currentOptions[2]; // Displays 3rd option 
                rbOptionD.Text = currentOptions[3]; // Displays 4th option 
                lblQuestionNo.Text = $"Question {_currentIndex + 1}/{_questions.Count}"; // Number to represent the question
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
                    btnReviewFlaggedQuestions.Visible = false; // while the user's are answering the quiz, they should not see the 'Review Flagged Questions' button.
                }
                else
                {
                    btnNext.Visible = false; // if not, it is not made visible
                    btnSubmit.Visible = true;
                    btnReviewFlaggedQuestions.Visible = true; // if the user is on the last question, the 'Review Flagged Questions' button is made visible.


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
                else { btnPrevious.Visible = true; } // if not (if the user is anywhere between the 2nd question and the last question) then the 'previous' button is made visible)
                if (isFlagged[index])
                {
                    btnFlag.Text = "Unflag";
                }
                else
                {
                    btnFlag.Text = "Flag Question";
                }



                UpdateNextButton();



            }
        }

        private void StartReviewMode()
        {
            _reviewIndex = 0; // when the user flags a question, the flagged questions are displayed starting with the VERY FIRST flagged question
            ShowReviewScreen();
        }

        private void ShowReviewScreen()
        {
            btnFlag.Visible = false;
            btnReviewFlaggedQuestions.Visible = false; // flag button and button for reviewing the flagged questions are hidden to make the UI more presentable
            rbOptionA.Checked = false; 
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
            btnPrevious.Text = "Go back to quiz";
            // all radio buttons are unchecked before the user answers any question
            if (_reviewIndex >= 0 && _reviewIndex < _flaggedQuestions.Count)
            {
                Question reviewQs = _flaggedQuestions[_reviewIndex]; // list storing the questions that have been flagged by the user.
                string[] flaggedQuestionOptions = reviewQs.GetOptions(); // gets the options (first option, 2nd, 3rd etc..)
                rbOptionA.Text = flaggedQuestionOptions[0]; // Displays 1st option 
                rbOptionB.Text = flaggedQuestionOptions[1]; // Displays 2nd option 
                rbOptionC.Text = flaggedQuestionOptions[2]; // Displays 3rd option 
                rbOptionD.Text = flaggedQuestionOptions[3]; // Displays 4th option
                lblQuestionNo.Text = $"Review: {_reviewIndex + 1}/{_flaggedQuestions.Count}"; // counter to indicate the index of the QUESTIONS THAT HAVE BEEN FLAGGED.
                lblQuestion.Text = reviewQs.GetText(); // displays the question of the question that have been flagged one at a time
                lblTopic.Text = $"Topic: {reviewQs.GetTopic()}"; // displays the topic of the flagged questions
                lblDifficulty.Text = reviewQs.GetDifficulty(); // displays the difficulty of the flagged question (the difficulty of the topic the user has chosen)

                if ((_reviewIndex+1) < _flaggedQuestions.Count)
                {
                    btnReviewNext.Visible = true; // whilt the question the user (while viewing their flagged questions)... 
                    btnSubmit.Visible = false; //... is on isn't the last question (ie the 1st question to penultimate question), the Next button specific to the reviewing section is shown and the submit button 
                    // isn't made visible.

                }
                else if (_reviewIndex == _flaggedQuestions.Count - 1)
                {
                    btnReviewNext.Visible = false; // if the user is on the last question...
                    btnSubmit.Visible = true; //... the next button WITHIN the reviewing of the flagged questions is made invisible and the submit button is made visible. 

                }
                if (_reviewIndex == 0)
                {
                   btnReviewPrevious.Visible = false; // if the index of the current question is at the
                                                      // start (the user is on the 1st question) then the 'previous' button isn't visible
                    rbOptionA.Checked = false;
                    rbOptionB.Checked = false;
                    rbOptionC.Checked = false;
                    rbOptionD.Checked = false;
                    // sll radio buttons are unchecked
                }
                else { btnReviewPrevious.Visible = true; } // if not, then the previous button is made visible, allowing the user to move back a question if they need to

                string savedAnswer = GetSavedAnswer(reviewQs);
                if (savedAnswer == rbOptionA.Text)
                {
                    rbOptionA.Checked = true; // if users previous option was option A, then option A is saved when they move back a question
                }
                else if (savedAnswer == rbOptionB.Text)
                {
                    rbOptionB.Checked = true; // if users previous option was option B, then option C is saved when they move back a question
                }
                else if (savedAnswer == rbOptionC.Text)
                {
                    rbOptionC.Checked = true; // if users previous option was option c, then option C is saved when they move back a question
                }
                else if (savedAnswer == rbOptionD.Text)
                {
                    rbOptionD.Checked = true;// if users previous option was option D, then option D is saved when they move back a question
                }
                else
                {
                    rbOptionA.Checked = false;
                    rbOptionB.Checked = false;
                    rbOptionC.Checked = false;
                    rbOptionD.Checked = false;
                }

            }


        }

        private void EndQuiz()
        {
            MarkQuiz();
            ReviewAnswersForm RAfrm = new ReviewAnswersForm(_questions, _userAnswers);
            RAfrm.Show();
            this.Close();



        }

        private string GetSavedAnswer(Question q)
        {
            if (_reviewIndex >= 0 && _reviewIndex < _userAnswers.Length) // if a user is reviewing a question, check if it has already been answered
            { return _userAnswers[_reviewIndex]; } // returns user's saved answer
            return ""; // an empty string is returned if no option is selected
        }

        private void SaveReviewAnswer()
        {
                if (rbOptionA.Checked)
                {
                    _userAnswers[_reviewIndex] = rbOptionA.Text; // if first option was selected, then the first option  is saved

                }
                else if (rbOptionB.Checked)
                {
                    _userAnswers[_reviewIndex] = rbOptionB.Text; // if 2nd option was selected then the 2nd option is saved
                }
                else if (rbOptionC.Checked)
                {
                    _userAnswers[_reviewIndex] = rbOptionC.Text; // if 3rd option was selected, then the 3rd option is saved
                }
                else if (rbOptionD.Checked)
                {
                    _userAnswers[_reviewIndex] = rbOptionD.Text; // if 4th option was selected, the 4th option is saved
                }
                else _userAnswers[_reviewIndex] = ""; // if nothing was selected, an empty string is saved
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentIndex == 0)
            {
                DialogResult Result = MessageBox.Show(
            $"Would you like to mark your progress? If you answer 5 questions correctly in a row on '{_questions[_currentIndex].GetTopic()}', you can try the next difficulty level.",
            "Track Your Progress?",
            MessageBoxButtons.YesNo);
                // when on the 1st question, user is asked whether they want their progress to be tracked or not
                if (Result == DialogResult.Yes)
                {
                    streaktracking = true; // if user agrees to track their progress, their steraks will be calculated

                }
            }
            SaveUserAnswer(); // when user moves forward, user answer is saved
            string uAnswers = _userAnswers[_currentIndex];
            string correctAnswer = _questions[_currentIndex].GetAnswer();
            if (streaktracking)
            {
                if (uAnswers == correctAnswer)
                {
                    streak++; // when marking, if the answer is correct, streak is incremented
                    score++;
                }
                else { streak = 0; } // if a question is wrong, streak is broken and reset to 0
                if (streak >= 5)
                {
                    string name = User.uName;
                    Results res = new Results(name, score); // if user answers 5 questions in a row correctly (provided that they have allowed their streak to be tracked)...
                    SaveResult(name, score); //...their scores are saved to the leaderboard
                    MessageBox.Show($"Well Done! You have answered 5 {_questions[_currentIndex].GetDifficulty()} questions correctly in a rown on the topic {_questions[_currentIndex].GetTopic()}, now try the next difficulty");
                    TopicSelectionForm TPfrm = new TopicSelectionForm(); // user gets to choose the next topic, topic selection form opens.
                    TPfrm.Show();
                    this.Close();
                } 
            }
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

        private void UpdateNextButton()
        {
            if (rbOptionA.Checked || rbOptionB.Checked || rbOptionC.Checked || rbOptionD.Checked)
            {
                btnNext.Enabled = true;
                btnNext.BackColor = SystemColors.Control;
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.BackColor = Color.Silver;
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
                string u = User.uName;
                QuizTimer.Stop(); // when timer hits 0... or if user submits the quiz
                EndQuiz();
                Results result = new Results(u, score);
                SaveResult(u, score);
                




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
            StreamWriter writeScoresTofile = File.AppendText("scores.csv"); // adds the username and results into a file labelled 'scores.csv'
            writeScoresTofile.WriteLine(username + ',' + score);
            writeScoresTofile.Close();
        }




        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            quizSubmitted = true;
            SaveUserAnswer();
            this.Hide();
        }

        private List<Question> ShuffleQuestions(List<Question> _OriginalQuestionList)
        {

            List<Question> shuffledList = new List<Question>();
            Random random = new Random();
            while (_OriginalQuestionList.Count > 0)
            {
                int index = random.Next(_OriginalQuestionList.Count); //Generates a random number to display questions in a random order

                Question selectedQuestion = _OriginalQuestionList[index]; // selects a random question from the list

                shuffledList.Add(selectedQuestion); // Adds the question from a specific position to the Randomised question list

                _OriginalQuestionList.RemoveAt(index);  // question is removed so that it doesn't get picked again
            }
            return shuffledList; //Returns the randomised question list

        }

        private void rbOptionA_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButton();

        }

        private void rbOptionB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButton();
        }

        private void rbOptionC_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButton();

        }

        private void rbOptionD_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNextButton();
            
        }

        private void lblDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            if (_currentIndex < 0 || _currentIndex > _questions.Count-1)
            {
                return;
            }
            isFlagged[_currentIndex] = !isFlagged[_currentIndex];
            if (isFlagged[_currentIndex])
            {
                _flaggedQuestions.Add(_questions[_currentIndex]);
                btnFlag.Text = "Unflag";
                btnNext.Enabled = true;
                btnNext.BackColor = SystemColors.Control;


            }
            else
            {
                _flaggedQuestions.Remove(_questions[_currentIndex]);
                btnFlag.Text = "Flag";
                btnNext.Enabled = false;
                btnNext.BackColor = Color.Silver;


            }
        }

        private void btnReviewNext_Click(object sender, EventArgs e)
        {
            SaveReviewAnswer();
            if (_reviewIndex <= _flaggedQuestions.Count-1) // if index of the question is in the question list range.
            {
                _reviewIndex++; // if user clicks on 'Next button'...
                ShowReviewScreen();
            }
        }

        private void btnReviewPrevious_Click(object sender, EventArgs e)
        {
            SaveReviewAnswer();
            if (_reviewIndex > 0)
            {
                _reviewIndex--;
                ShowReviewScreen();
            }
        }

        private void btnReviewFlaggedQuestions_Click(object sender, EventArgs e)
        {
            if (_currentIndex == _questions.Count - 1)
            {
                if (_flaggedQuestions.Count > 0)
                {
                    DialogResult result = MessageBox.Show($"You have {_flaggedQuestions.Count} flagged questions.\n" + "Would you like to review them before finishing?", "Review Flagged Questions", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        StartReviewMode();
                    }
                    else
                    {
                        MessageBox.Show("You can click 'Submit Quiz' when ready.");
                    }
                }
                else
                {
                    MessageBox.Show("No flagged Questions. You can click 'Submit Quiz' when ready.");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
