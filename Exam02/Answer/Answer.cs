using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Answer : IComparable<Answer>, ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString()
        {
            return $"{AnswerId} ) {AnswerText}";
        }

        public int CompareTo(Answer? other)
        {
            if (other == null) return 1;
            return this?.AnswerId.CompareTo(other.AnswerId) ?? (other is not null ? -1 : 0);
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
    }
}
