using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Exam Exam { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void CreatExam()
        {
            uint examtype, time, question;


            do
            {
                Console.WriteLine("Please Enter The Type Of Exam You Want To Create(1 for Practical and 2 for Final)");
            }
            while (!((uint.TryParse(Console.ReadLine(), out examtype)) && (examtype == 1 || examtype == 2)));

            do
            {
                Console.WriteLine("Please Enter Time of Exam in Minutes: ");
            }
            while (!uint.TryParse(Console.ReadLine(), out time));
            do
            {
                Console.WriteLine("Please Enter The Number of Questions you want to Create: ");
            }
            while (!uint.TryParse(Console.ReadLine(), out question));


            if (examtype == 1)
            {
                Exam = new PracticalExam(time, question, new QuestionBase[question]);
                Exam.Questions = Exam.ExamCreation(Exam.NumberOfQuestions);

            }
            else
            {

                Exam = new FinalExam(time, question, new QuestionBase[question]);
                Exam.Questions = Exam.ExamCreation(Exam.NumberOfQuestions);
            }
        }

    }
}
