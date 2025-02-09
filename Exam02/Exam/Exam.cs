using Exam02.question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public List<QuestionBase> Questions { get; set; }

        public Exam(int time, int numberofquestions)
        {
            Time = time;
            NumberOfQuestions = numberofquestions;
            Questions = new List<QuestionBase>();
        }
        abstract public QuestionBase[] ExamCreation(int numberofQuestion);
      

        public void PrintExam()
        {
            Console.WriteLine($"Time : {Time}\t Number Of Questions : {NumberOfQuestions}");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine(Questions[i].ToString());
            }
        }

        public void ShowExam()
        {
            Console.WriteLine($"Time : {Time}\t Number Of Questions : {NumberOfQuestions}");
            int degree = 0;
            QuestionBase.Answers = new Answer[NumberOfQuestions, 2];
            Answer UserAnswer = null;
            string usertext;
            int userAnswerId, AnswerId;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                QuestionBase.Answers[i, 1] = Questions[i].RightAnswer;
                Console.WriteLine(Questions[i].ToString());
                do
                {
                    Console.Write("Enter you Answer Choice Number:");
                } while (int.TryParse(Console.ReadLine(), out userAnswerId) && Questions[i].Choices.Length < userAnswerId);
                Console.WriteLine("==========================================================");

                UserAnswer = (Answer)Questions[i].Choices[userAnswerId - 1].Clone();

                QuestionBase.Answers[i, 0] = UserAnswer;
                //if (useranswerId == Questions[i].RightAnswer.AnswerId)
                //{
                //    degree += Questions[i].Mark;
                //}
                if (Questions[i].RightAnswer.CompareTo(UserAnswer) == 0)
                {
                    degree += Questions[i].Mark;
                }

            }
            Console.Clear();
            Console.WriteLine($"your Degree is :{degree}");
            Console.WriteLine($"Your Answers\t\t\t\tTrue Answers");
            for (int i = 0; i < QuestionBase.Answers.GetLength(0); i++)
            {
                for (int j = 0; j < QuestionBase.Answers.GetLength(1); j++)
                {
                    Console.Write(QuestionBase.Answers[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
