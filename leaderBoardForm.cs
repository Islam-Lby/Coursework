using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class leaderBoardForm : Form
    {
        public leaderBoardForm()
        {
            InitializeComponent();
            LoadResults();
            DisplayScores();
        }

        private void leaderBoardForm_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DodgerBlue; // sets the background colour to 'DodgerBlue'

        }

        private void DisplayScores()
        {

            List<Results> allResults = LoadResults(); // creates a new instance of the Results class
            Leader_board board = new Leader_board(); // creates a new instance of the Leaderboard class
            foreach (Results r in allResults)
            {
                board.AddResults(r); // Adds the results stored from the CSV file
            }
            board.SortResults(); // Sorts the results using an insertion sort in descending order
            List<Results> sortedResults = board.GetResults();

            for (int i = 0; i <=10; i++)
            {
                Results r = sortedResults[i];
                string rank = (i + 1) + ". ";
                lstScores.Items.Add(rank + r.GetuserName() + " - " + r.Getscore()); // outputs the score in a list box with a number to rank the scoers '1st, 2nd 3rd' etc
                
            }

        }

        private List<Results> LoadResults()
        {
            List<Results> results = new List<Results>(); // stores the list of results

            try
            {
                StreamReader reader = new StreamReader("scores.csv"); // opens and reads in the file called "scores.csv
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(','); // splits each line of the file based on the comma
                    string username = parts[0]; // stoers the username
                    int score = int.Parse(parts[1]); // stores the score
                    Results r = new Results(User.uName, score); // adds BOTH the score and the username into 1 object to store on a single line 
                    results.Add(r); // adds to the list of results
                }
                reader.Close(); // closes the file
            }
            catch 

            {
                MessageBox.Show("File doesn't exist"); // if the file doesn't exist, the program stops
                Environment.Exit(0);
            }

            return results;
        }


    }
}

