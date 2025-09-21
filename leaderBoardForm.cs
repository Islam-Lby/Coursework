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
            this.BackColor = System.Drawing.Color.DodgerBlue;

        }

        private void DisplayScores()
        {

            // Load all results from file
            List<Results> allResults = LoadResults();

            // Create a Leaderboard object and add results
            Leader_board board = new Leader_board();
            foreach (Results r in allResults)
            {
                board.AddResults(r);
            }
            board.SortResults();
            List<Results> sortedResults = board.GetResults();

            // Display in listbox
            foreach (Results r in sortedResults)
            {
                lstScores.Items.Add(r.GetuserName() + " - " + r.Getscore());
            }

        }

        private List<Results> LoadResults()
        {
            List<Results> results = new List<Results>();

            try
            {
                // Open the file to read
                StreamReader reader = new StreamReader("scores.CSV");

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Split the line by comma
                    string[] parts = line.Split(',');

                    // Get username and score
                    string username = parts[0];
                    int score = int.Parse(parts[1]);

                    // Create a Result and add to list
                    Results r = new Results(username, score);
                    results.Add(r);
                }

                // Close the file
                reader.Close();
            }
            catch (Exception)
            {
                // If file doesn't exist or has errors, just return empty list
            }

            return results;
        }


    }
}

