using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    internal class Leader_board
    {
        private List<Results> _results; 

        public Leader_board()
        {
            _results = new List<Results>();
        }

        public void AddResults(Results result)
        {
            _results.Add(result); // adds the results to a list which can then be used to display leaderboardI 
        }

        public List<Results> GetResults()
        {
            return _results;
        }

        public void SortResults() // insertion sort to display usernames 
        {
            for (int i = 1; i < _results.Count; i++)
            {
                Results current = _results[i];
                int j = i - 1;

                while (j >= 0 && _results[j].Getscore() < current.Getscore())
                {
                    _results[j + 1] = _results[j];
                    j--;
                }

                _results[j + 1] = current;
            }
        }
    }
}
