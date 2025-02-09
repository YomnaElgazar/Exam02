using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.question
{
    public abstract class QuestionBase
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer RightAnswer { get; set; }
        public static Answer[,] Answers { get; set; }
        public Answer[] Choices;





        public QuestionBase(string header, string body, int mark, Answer[] choices)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Choices = choices;

        }
        public override string ToString()
        {

            string choice = Choices != null ? string.Join($"\n", Choices.ToList()) : "No Choices";
            return $"{Header}  Mark:{Mark}\n{Body}\n{choice}\n------------------------------------------------";
        }
    }
}
