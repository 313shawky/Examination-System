using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class MCQQuestion : QuestionBase
    {
        public override string Header { get => "Choose one answer question"; }

        public MCQQuestion()
        {
            AnswersList = new Answer[3];
            RightAnswer = new Answer();
            ExamineeAnswer = new Answer();
        }

        public override void SetAnswers()
        {
            string text;
            int rightAnswerId;
            Console.WriteLine("The Choices of Question:");
            if (AnswersList is not null)
                for(int i = 0; i < AnswersList.Length; i++)
                {
                    do
                    {
                        Console.Write($"Please Enter The Choice Number {i + 1}: ");
                        text = Console.ReadLine() ?? "";
                    } while (string.IsNullOrWhiteSpace(text));
                
                    AnswersList[i] = new Answer(i + 1, text);
                }

            do
            {
                Console.WriteLine("Please Specify The Right Choice of Question:");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId < 1 || rightAnswerId > 3));
            if (RightAnswer is not null)
            {
                RightAnswer.AnswerId = rightAnswerId;
                if (AnswersList is not null)
                    RightAnswer.AnswerText = AnswersList[rightAnswerId - 1].AnswerText;
            }
        }
    }
}
