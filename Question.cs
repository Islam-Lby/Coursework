using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Question // Stores all the details about the quiz
    {
        private string _topic;
        private string _text;
        private string[] _options;
        private string _answer;
        private string _difficulty;
        // ^^ Quiz attributes
        public Question(string difficulty, string topic, string text, string[] options, string answer) // constructor passing in the attributes, in similar format to the quiz file itself.
        {
            _difficulty = difficulty;
            _topic = topic;
            _text = text;
            _options = options;
            _answer = answer;
            
        }
        public string GetDifficulty()
        {
            return _difficulty;
        }
        public string GetTopic()
        {
            return _topic;
        }

        public string GetText()
        {
            return _text;
        }

        public string[] GetOptions()
        {
            return _options;
        }

        public string GetAnswer()
        {
            return _answer;
        }
        
    }
}
