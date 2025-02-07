using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject01 = new Subject(10, "C#");
            subject01.CreatExam();
            Console.Clear();
            subject01.Exam.PrintExam();

            Console.WriteLine("Do You Want to start the exam (y | n)");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject01.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
           

        }

    }
}

