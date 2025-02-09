using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.question
{
    public class MCQ_Question : QuestionBase
    {
        public MCQ_Question(string body, int mark, Answer[] choices, int RightAnswerIndex)
            : base("Choose One Answer Question", body, mark, choices)
        {
            RightAnswer = Choices[RightAnswerIndex];

        }
        public static MCQ_Question CreateQuestion()
        {
            Console.WriteLine("MCQ Question : ");
            Console.WriteLine("Please Enter Body of Question: ");
            string _body; int _mark;

            do
            {
                Console.WriteLine("Please Enter Body of Question: ");
                _body = Console.ReadLine() ?? string.Empty;

            } while (_body == string.Empty);
            do
            {
                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!int.TryParse(Console.ReadLine(), out _mark));

            int size;
            int choice;

            do
            {
                Console.WriteLine("Please Enter Number Of Choices You Want to Give : ");
            } while (!int.TryParse(Console.ReadLine(), out size));

            Console.WriteLine("The Choices of the Question : ");
            Answer[] Choices = new Answer[size];
            for (int i = 0; i < Choices.Length; i++)
            {
                var answer = string.Empty;
                do
                {
                    Console.Write($"Please Enter the Choice Number {i + 1} : ");
                    answer = Console.ReadLine() ?? string.Empty;
                } while (answer == string.Empty);
                Choices[i] = new Answer(i + 1, answer);
            }
            do
            {
                Console.WriteLine("Please Spacify The right Choice: ");
            }
            while (!(int.TryParse(Console.ReadLine(), out choice) && choice <= Choices.Length));
            return new MCQ_Question(_body, _mark, Choices, choice - 1);

        }
        //public override string ToString()
        //{

        //    string choice = Choices != null ? string.Join($"\n", Choices.ToString()) : "No Choices";
        //    return $"{Header}  Mark:{Mark}\n{Body}\n{choice}\n------------------------------------------------";
        //}

    }
}
