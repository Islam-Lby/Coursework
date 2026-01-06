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
    public partial class TopicSelectionForm : Form
    {
        private string _selectedTopic;
        private string _selectedDifficulty;
        
        public TopicSelectionForm()
        {
            InitializeComponent();

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (cmbTopics.SelectedItem == null)
            {
                MessageBox.Show("Please select a topic."); // if nothing has been selected, output this message
                return;
            }
            if (cmbDifficulty.SelectedItem == null)
            {
                MessageBox.Show("Please select a difficulty."); // if nothing has been selected, output this message
                return;
            }
                _selectedTopic = cmbTopics.SelectedItem.ToString(); // stores the selected topic
            _selectedDifficulty = cmbDifficulty.SelectedItem.ToString();
            btnSubmitQuiz quizForm = new btnSubmitQuiz(_selectedTopic, _selectedDifficulty); // creates a new quiz form to answer questions                
                                                              // based off the selected topic
            quizForm.Show(); // opens the quiz form with the selected topic questions being displayed
            this.Hide(); // hides the current form

        }

        private void TopicSelectionForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue;

            cmbTopics.Items.Add("Web Technologies");
            cmbTopics.Items.Add("Compression Encryption and Hashing");
            cmbTopics.Items.Add("IDEs and their functions");
            cmbTopics.Items.Add("Structure and Function of the CPU");
            cmbTopics.Items.Add("Networks");

            cmbDifficulty.Items.Add("Easy");
            cmbDifficulty.Items.Add("Medium");
            cmbDifficulty.Items.Add("Hard");




        }

        private void cmbTopics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
