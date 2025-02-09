using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.subject
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        /// <summary>
        /// Create Exam Method to  Define the Type of Exam and Create it
        /// </summary>
        public void CreatExam()
        {
            int examtype, time, questionsNumber;


            do
            {
                Console.WriteLine("Please Enter The Type Of Exam You Want To Create(1 for Practical and 2 for Final)");
            }
            while (!(int.TryParse(Console.ReadLine(), out examtype) && (examtype == 1 || examtype == 2)));

            do
            {
                Console.WriteLine("Please Enter Time of Exam in Minutes: ");
            }
            while (!int.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.WriteLine("Please Enter The Number of Questions you want to Create: ");
            }
            while (!int.TryParse(Console.ReadLine(), out questionsNumber));


            if (examtype == 1)
            {
                Exam = new PracticalExam(time, questionsNumber);
                Exam.Questions = Exam.ExamCreation(Exam.NumberOfQuestions).ToList();

            }
            else
            {

                Exam = new FinalExam(time, questionsNumber);
                Exam.Questions = Exam.ExamCreation(Exam.NumberOfQuestions).ToList();
            }
        }

    }

}
