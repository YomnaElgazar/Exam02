using Exam02.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.helpers
{
    public static  class QuestionsHelper
    {
        public static TrueFalseQuestion CreateTrueOrFalesQuestion(int i, QuestionBase[] tFQuestions)
        {
            Console.Clear();
            Console.WriteLine("True | False Question : ");
            Console.WriteLine($"Question Number {i + 1}");
            return TrueFalseQuestion.CreateQuestion();
        }
        public static MCQ_Question CreateMCQQuestion(int i, QuestionBase[] mcqQuestions)
        {
            Console.Clear();
            Console.WriteLine("MCQ Question : ");
            Console.WriteLine($"Question Number {i + 1}");
            return MCQ_Question.CreateQuestion();
        }
    }
}
