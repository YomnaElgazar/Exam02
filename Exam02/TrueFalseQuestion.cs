using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueFalseQuestion : QuestionBase
    {
        private static Answer[] defaultanswers = [new Answer("1", "True"), new Answer("2", "False")];
        public TrueFalseQuestion(String body, uint mark,bool rightAnswer)
            : base("True | False Question", body, mark, defaultanswers)
        {
            RightAnswer=rightAnswer? defaultanswers[0]: defaultanswers[1];
        }

        public static TrueFalseQuestion Question()
        {

            Console.WriteLine("Please Enter Body of Question: ");
            string _body; uint _mark;
           
            do
            {
                Console.WriteLine("Please Enter Body of Question: ");
                _body = Console.ReadLine() ?? string.Empty;

            } while (_body == string.Empty);

            do
            {
     
                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!uint.TryParse(Console.ReadLine(), out _mark));
            string answer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer For the Question (1 For True | 2 for False)");
                answer = Console.ReadLine()??" ";
            }
            while (!(answer.Equals("1")|| answer.Equals("2")));
            if (answer.Equals("1"))
                return new TrueFalseQuestion(_body, _mark,true);
            else
                return new TrueFalseQuestion(_body, _mark, false);

        }
        public override string ToString()
        {
            return $"{Header}   Mark:{Mark}\n{Body}\n{defaultanswers.ToString()}\n--------------------------------------------";
        }

    }
}
