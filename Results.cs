using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Results // holds the results and username of the user AFTER completing the quiz
    {
        private string name; // stores the username enterd by the user,uit is then used in the username for,
        private int score; // store the score that the user has achieved after they have completed the quiz

        public Results(string name, int score) 
        {
            this.name = name;
            this.score = score;
        }
        public string GetuserName()
        {
            return name; 
        }
        public int Getscore()
        {
            return score;
        }


    }
}
