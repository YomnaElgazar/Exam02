using Exam02.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int number) : base(time, number)
        {

        }
        public override QuestionBase[] ExamCreation(int numberofQuestion)
        {

            QuestionBase[] tFQuestions = new QuestionBase[numberofQuestion];
            for (int i = 0; i < numberofQuestion; i++)
            {
               TrueFalseQuestion.CreateQuestion();
            }
            return tFQuestions;
        }

    }
}

