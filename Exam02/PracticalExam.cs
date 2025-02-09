using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(uint time, uint number) : base(time, number)
        {

        }
        public override QuestionBase[] ExamCreation(uint numberofQuestion)
        {

            QuestionBase[] tFQuestions = new QuestionBase[numberofQuestion];
            for (int i = 0; i < numberofQuestion; i++)
            {
                PracticalExamBehavior(i, tFQuestions);
            }
            return tFQuestions;
        }

    }
}

