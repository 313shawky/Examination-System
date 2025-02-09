using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class FinalExam : Exam
    {
        public override void SetQuestions()
        {
            int questionType;
            for (int i = 0; i < NoOfQuestions; i++)
            {
                Console.Clear();
                do
                {
                    Console.Write($"Please Choose The Type of Question Number({i + 1})   (1 for True OR False || 2 for MCQ): ");
                } while (!int.TryParse(Console.ReadLine(), out questionType) || (questionType != 1 && questionType != 2));
                if (questionType == 1)
                {
                    QuestionBase q = new TFQuestion();
                    q.CreateQuestion();
                    QuestionsList.Add(q);
                }
                else if (questionType == 2)
                {
                    QuestionBase q = new MCQQuestion();
                    q.CreateQuestion();
                    QuestionsList.Add(q);
                }
            }
        }

        public override void ShowResult()
        {
            Console.Clear();
            Console.WriteLine("Your Answers:");
            for (int i = 0; i < QuestionsList.Count; i++)
            {
                Console.WriteLine($"Q{i + 1})\t{QuestionsList[i].Body}: {QuestionsList[i].ExamineeAnswer?.AnswerText}");
            }
            Console.WriteLine($"\nYour Exam Grade is {ExaminerGrade} of {FullMark}");
        }
    }
}
