using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "Math");
            subject.CreateExam();
            Console.Clear();
            Console.Write("Do You Want to Start The Exam? (y | n): ");

            if (char.Parse(Console.ReadLine() ?? "") == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                if (subject.Exam is not null)
                    subject.Exam.ShowExam();

                Console.WriteLine($"\nThe Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}