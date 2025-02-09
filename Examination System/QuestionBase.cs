using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class QuestionBase
    {
        public virtual string? Header { get; }
        public string? Body { get; set; }
        public int Marks { get; set; }
        public Answer[]? AnswersList { get; set; }
        public Answer? RightAnswer { get; set; }
        public Answer? ExamineeAnswer { get; set; }

        public void CreateQuestion()
        {
            Console.Clear();
            int marks;
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Please Enter The Body of Question:");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

            do
            {
                Console.WriteLine("Please Enter The Marks of Question:");
            } while (!int.TryParse(Console.ReadLine(), out marks));
            Marks = marks;

            SetAnswers();
        }

        public override string ToString()
        {
            return $"{Header}\t\t\tMarks({Marks})\n\n{Body}";
        }

        public bool CheckAnswer()
        {
            return RightAnswer?.AnswerId == ExamineeAnswer?.AnswerId;
        }

        public abstract void SetAnswers();
    }
}
