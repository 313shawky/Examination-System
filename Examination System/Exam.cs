using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NoOfQuestions { get; set; }
        public int ExaminerGrade { get; set; }
        public int FullMark { get; set; }

        public List<QuestionBase> QuestionsList = new List<QuestionBase>();

        public abstract void SetQuestions();

        public void ShowExam()
        {
            Console.Clear();
            ExaminerGrade = 0;
            FullMark = 0;
            QuestionsList.ForEach(q =>
            {
                Console.WriteLine(q.ToString());
                FullMark += q.Marks;
                if (q.AnswersList is not null)
                    foreach (Answer answer in q.AnswersList)
                    {
                        Console.Write(answer.ToString());
                    }
                Console.WriteLine("\n----------------------------------------------------------------------");
                int examineeAnswerId;
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out examineeAnswerId) || (examineeAnswerId < 1 || examineeAnswerId > q.AnswersList?.Length));

                if (q.ExamineeAnswer is not null && q.AnswersList is not null)
                {
                    q.ExamineeAnswer.AnswerId = examineeAnswerId;
                    q.ExamineeAnswer.AnswerText = q.AnswersList[examineeAnswerId - 1].AnswerText;
                }

                if (q.CheckAnswer())
                    ExaminerGrade += q.Marks;

                Console.WriteLine("========================================================================\n");
            });
            ShowResult();
        }

        public abstract void ShowResult();
    }

}
