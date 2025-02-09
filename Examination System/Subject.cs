using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam? Exam { get; set; }

        public Subject(int SubjectId, string SubjectName)
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;
        }

        public void CreateExam()
        {
            int examType, examTime, questionNo;
            do
            {
                Console.Write("Please Enter The Type of Exam You Want to Create(1 for Practical and 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            if (examType == 1)
                Exam = new PracticalExam();
            if (examType == 2)
                Exam = new FinalExam();

            do
            {
                Console.Write("Please Enter The Time of Exam in Minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out examTime));
            if (Exam is not null)
                Exam.TimeOfExam = examTime;

            do
            {
                Console.Write("Please Enter The Number of Questions You Want to Create: ");
            } while (!int.TryParse(Console.ReadLine(), out questionNo));
            if (Exam is not null)
                Exam.NoOfQuestions = questionNo;

            if (Exam is not null)
                Exam.SetQuestions();
        }
    }
}
