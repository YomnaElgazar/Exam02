using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal abstract class Exam
    {
        public uint Time { get; set; }
        public uint NumberOfQuestions { get; set; }
        public QuestionBase[] Questions { get; set; }

        public Exam(uint time, uint numberofquestions, QuestionBase[] questions)
        {
            Time = time;
            NumberOfQuestions = numberofquestions;
            Questions = questions;
        }
        abstract public QuestionBase[] ExamCreation(uint numberofQuestion);
        public static void PracticalExamBehavior(int i, QuestionBase[] tFQuestions)
        {
            Console.Clear();
            Console.WriteLine("True | False Question : ");
            Console.WriteLine($"Question Number {i + 1}");
            TrueFalseQuestion tFQuestion = TrueFalseQuestion.Question();
            tFQuestions[i] = tFQuestion;
            Console.Clear();
        }

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
            uint degree = 0;          
            QuestionBase.Answers = new Answer[NumberOfQuestions, 2];
            Answer UserAnswer = new Answer();
            string usertext;
            string useranswerId, AnswerId;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                QuestionBase.Answers[i, 1] = Questions[i].RightAnswer;
                Console.WriteLine(Questions[i].ToString());
                Console.Write("Enter you Answer Choice Number:");
                useranswerId = Console.ReadLine();
                Console.WriteLine("==========================================================");
               
                
                for (int j = 1; j <= Questions[i].Choices.Length; j++)
                {
                    if (useranswerId == j.ToString())
                    {
                        if (Questions[i].Choices.Length > 2)
                        {
                            usertext = Questions[i].Choices[i];
                            UserAnswer = new Answer(useranswerId, usertext);
                            break;
                        }
                        else
                        {
                            usertext = Questions[i].Choices[j-1];
                            UserAnswer = new Answer(useranswerId, usertext);
                            break;
                        }
                    }

                }
                QuestionBase.Answers[i, 0] = UserAnswer;
                if (useranswerId == Questions[i].RightAnswer.AnswerId)
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
