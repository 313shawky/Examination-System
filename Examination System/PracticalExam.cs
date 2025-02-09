using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class PracticalExam : Exam
    {
        public override void SetQuestions()
        {
            for (int i = 0; i < NoOfQuestions; i++)
            {
                QuestionBase q = new MCQQuestion();
                q.CreateQuestion();
                QuestionsList.Add(q);
            }
        }

        public override void ShowResult()
        {
            Console.Clear();
            Console.WriteLine("Right Answers:");
            for (int i = 0; i < QuestionsList.Count; i++)
            {
                Console.WriteLine($"Q{i + 1})\t{QuestionsList[i].Body}: {QuestionsList[i].RightAnswer?.AnswerText}");
            }
        }
    }
}
