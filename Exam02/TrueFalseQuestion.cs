using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueFalseQuestion :QuestionBase
    {
        
        public TrueFalseQuestion(String body, uint mark, string answerId, string answerText) : base("True | False Question", body, mark)
        {

            Choices = new string[2] { "True", "False" };
            RightAnswer = new Answer(answerId, answerText);
        }

        public static TrueFalseQuestion Question()
        {

            Console.WriteLine("Please Enter Body of Question: ");
            string _body; uint _mark;
            _body = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!uint.TryParse(Console.ReadLine(), out _mark));
            string answer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer For the Question (1 For True | 2 for False)");
                answer = Console.ReadLine();
            }
            while (!(answer.Equals("1")|| answer.Equals("2")));
            if (answer.Equals("1"))
                return new TrueFalseQuestion(_body, _mark, "1", "True");
            else
                return new TrueFalseQuestion(_body, _mark, "2", "False");

        }
        public override string ToString()
        {
            return $"{Header}   Mark:{Mark}\n{Body}\n1).True\t2).False\n--------------------------------------------";
        }

    }
}
