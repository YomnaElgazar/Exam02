using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Answer
    {
        public string AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(string answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
       public Answer() { }
        public override string ToString()
        {
            return $"AnswerId = {AnswerId} , AnswerText = {AnswerText}";
        }

    }
}
