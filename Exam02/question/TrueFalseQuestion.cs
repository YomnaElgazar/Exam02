using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.question
{
    public class TrueFalseQuestion : QuestionBase
    {
        private static Answer[] _defaultanswers = [new Answer(1, "True"), new Answer(2, "False")];
        public TrueFalseQuestion(string body, int mark, bool rightAnswer)
            : base("True | False Question", body, mark, _defaultanswers)
        {
            RightAnswer = rightAnswer ? _defaultanswers[0] : _defaultanswers[1];
        }

        public static TrueFalseQuestion CreateQuestion()
        {
            Console.WriteLine("True | False Question : ");
            Console.WriteLine("Please Enter Body of Question: ");
            string body; int mark;

            do
            {
                Console.WriteLine("Please Enter Body of Question: ");
                body = Console.ReadLine() ?? string.Empty;

            } while (body == string.Empty);

            do
            {

                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!int.TryParse(Console.ReadLine(), out mark));
            string _answer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer For the Question t For True | f for False)");
                _answer = Console.ReadLine() ?? " ";
            }
            while (!(_answer.Equals("t") || _answer.Equals("f")));
            if (_answer.Equals("t"))
                return new TrueFalseQuestion(body, mark, true);
            else
                return new TrueFalseQuestion(body, mark, false);

        }
        //public override string ToString()
        //{
        //    return $"{Header}   Mark:{Mark}\n{Body}\n{defaultanswers    ToString()}\n--------------------------------------------";
        //}

    }
}
