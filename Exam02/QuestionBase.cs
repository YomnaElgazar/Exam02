using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class QuestionBase
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public uint Mark { get; set; }

        public Answer RightAnswer { get; set; }
        public static Answer[,] Answers { get; set; }
        public Answer[] Choices;

        



        public QuestionBase(string header, string body, uint mark, Answer[] choices)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Choices = choices;
            
        }

    }
}
