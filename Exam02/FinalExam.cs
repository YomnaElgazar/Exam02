using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(uint time, uint number, QuestionBase[] questions) : base(time, number, questions)
        {

        }
        public override QuestionBase[] ExamCreation(uint numberofQuestion)
        {
            QuestionBase[] questions = new QuestionBase[numberofQuestion];

            for (int i = 0; i < numberofQuestion; i++)
            {

                uint typeofQuestion;
                do
                {
                    Console.WriteLine($"Please Enter Type Of Question Number {i + 1} (1 for True or False || 2 for MCQ) : ");
                }
                while (!((uint.TryParse(Console.ReadLine(), out typeofQuestion)) && (typeofQuestion == 1 || typeofQuestion == 2)));
                if (typeofQuestion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Choose The Correct Answer :");
                    Console.WriteLine($"Question Number {i + 1}");
                    MCQ_Question MCQquestion = MCQ_Question.Question();
                    questions[i] = MCQquestion;
                    Console.Clear();
                }
                else
                {
                    PracticalExam.PracticalExamBehavior(i, questions);
                }

            }
            return questions;
        }
    }
}
