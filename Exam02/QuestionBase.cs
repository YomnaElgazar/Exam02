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

        public Answer RightAnswer { get; set; }
        public static Answer[,] Answers { get; set; }
        public string[] Choices;

        public string Body { get; set; }
        public uint Mark { get; set; }
        



        public QuestionBase(string header, String body, uint mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            
        }

    }
}
