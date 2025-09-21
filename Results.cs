using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Results
    {
        private string name;
        private int score;

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
