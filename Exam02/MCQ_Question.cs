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
        public MCQ_Question(String body, uint mark, Answer[] choices,int RightAnswerIndex) 
            : base("Choose One Answer Question", body, mark, choices)
        {
            //Choices = choices;
            RightAnswer = Choices[RightAnswerIndex];
           // RightAnswer = new Answer(answerId, answerText);

        }
        public static MCQ_Question Question()
        {

            Console.WriteLine("Please Enter Body of Question: ");
            string _body; uint _mark;
           
            do
            {
                Console.WriteLine("Please Enter Body of Question: ");
                _body = Console.ReadLine() ?? String.Empty;

            } while (_body==String.Empty);
            do
            {
                Console.WriteLine("Please Enter The Mark of Question :");
            } while (!uint.TryParse(Console.ReadLine(), out _mark));
            
            uint  size;
            int choice;
            
            do
            {
                Console.WriteLine("Please Enter Number Of Choices You Want to Give : ");
            } while (!uint.TryParse(Console.ReadLine(), out size));

            Console.WriteLine("The Choices of the Question : ");
            Answer[] Choices = new Answer[size];
            for (int i = 0; i < Choices.Length; i++)
            {
                Choices[i].AnswerId = $"{i+1}";
                do
                {
                Console.Write($"Please Enter the Choice Number {i + 1} : ");
                    Choices[i].AnswerText = Console.ReadLine() ??string.Empty; 
                } while (Choices[i].AnswerText==string.Empty);
            }
            do
            {
                Console.WriteLine("Please Spacify The right Choice: ");
            }
            while (!((int.TryParse(Console.ReadLine(), out choice)) && (choice <= Choices.Length)));
            return new MCQ_Question(_body, _mark, Choices,choice-1);

        }
        public override string ToString()
        {
    
            string choice = Choices != null ? string.Join($"\n", Choices.ToString()) : "No Choices";
            return $"{Header}  Mark:{Mark}\n{Body}\n{choice}\n------------------------------------------------";
        }

    }
}
