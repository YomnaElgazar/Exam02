using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQ_Question :QuestionBase
    {
        public MCQ_Question(String body, uint mark, string[] choices, string answerId, string answerText) : base("Choose One Answer Question", body, mark)
        {
            Choices = choices;
            RightAnswer = new Answer(answerId, answerText);

        }
        public static MCQ_Question Question()
        {

            Console.WriteLine("Please Enter Body of Question: ");
            string _body; uint _mark;
            _body = Console.ReadLine();
            do
            {
                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!uint.TryParse(Console.ReadLine(), out _mark));
            
            uint choice, size;
            
            do
            {
                Console.WriteLine("Please Enter Number Of Choices You Want to Give : ");
            } while (!uint.TryParse(Console.ReadLine(), out size));

            Console.WriteLine("The Choices of the Question : ");
            string[] Choices = new string[size];
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.Write($"Please Enter the Choice Number {i + 1} : ");
                Choices[i] = Console.ReadLine();
            }
            do
            {
                Console.WriteLine("Please Spacify The right Choice: ");
            }
            while (!((uint.TryParse(Console.ReadLine(), out choice)) && (choice <= Choices.Length)));
            return new MCQ_Question(_body, _mark, Choices, choice.ToString(), Choices[choice - 1]);

        }
        public override string ToString()
        {
            string choice = Choices != null ? string.Join($"\n", Choices) : "No Choices";
            return $"{Header}  Mark:{Mark}\n{Body}\n{choice}\n------------------------------------------------";
        }

    }
}
