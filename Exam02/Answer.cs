using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Answer :IComparable<Answer> ,ICloneable
    {
        public string AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(string answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
       public Answer() { }
        public Answer(Answer? copyAnswer)
        {
            AnswerId = copyAnswer.AnswerId;
            AnswerText = copyAnswer.AnswerText;
        }
        public override string ToString()
        {
            return $"AnswerId = {AnswerId} , AnswerText = {AnswerText}";
        }

        public int CompareTo(Answer? other)
        {
            if (other == null) return 1 ;
            return this?.AnswerId.CompareTo(other.AnswerId) ??(other is not null? -1: 0);
        }

        public object Clone()
        {
            return new Answer()
            {
                AnswerId = this.AnswerId,
                AnswerText = this.AnswerText
            };
            
        }
    }
}
