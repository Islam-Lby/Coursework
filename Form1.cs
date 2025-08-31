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

            _selectedTopic = cmbTopics.SelectedItem.ToString(); // stores the selected topic
            QuizForm quizForm = new QuizForm(_selectedTopic); // creates a new quiz form to answer questions
                                                              // based off the selected topic
            quizForm.Show(); // opens the quiz form with the selected topic questions being displayed
            this.Hide(); // hides the current form

        }

        private void TopicSelectionForm_Load(object sender, EventArgs e)
        {
            cmbTopics.Items.Add("Web Technologies");
            cmbTopics.Items.Add("Compression Encryption and Hashing");
            cmbTopics.Items.Add("IDEs and their functions");
            cmbTopics.Items.Add("Structure and Function of the CPU");
            cmbTopics.Items.Add("Networks");
        }
    }
}
