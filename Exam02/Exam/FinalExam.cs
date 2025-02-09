using Exam02.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int number) : base(time, number)
        {

        }
        public override QuestionBase[] ExamCreation(int numberofQuestion)
        {
            var questions = new QuestionBase[numberofQuestion];

            for (int i = 0; i < numberofQuestion; i++)
            {

                int typeofQuestion;
                do
                {
                    Console.WriteLine($"Please Enter Type Of Question Number {i + 1} (1 for True or False || 2 for MCQ) : ");
                }
                while (!(int.TryParse(Console.ReadLine(), out typeofQuestion) && (typeofQuestion == 1 || typeofQuestion == 2)));
                Console.Clear();
                Console.WriteLine($"Question Number {i + 1}");
                if (typeofQuestion == 2)
                {
                    questions[i] = MCQ_Question.CreateQuestion();
                }
                else
                {
                    questions[i] = TrueFalseQuestion.CreateQuestion();
                }

            }
            return questions;
        }
    }
}
