using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examination_System
{
    class TFQuestion : QuestionBase
    {
        public override string Header { get => "True | False Question\t"; }

        public TFQuestion()
        {
            AnswersList = new Answer[2] { new Answer(1, "True"), new Answer(2, "False") };
            RightAnswer = new Answer();
            ExamineeAnswer = new Answer();
        }

        public override void SetAnswers()
        {
            int rightAnswerId;

            do
            {
                Console.Write("Please Enter The Right Answer of Question (1 for True and 2 for False): ");
            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || (rightAnswerId != 1 && rightAnswerId != 2));

            if (RightAnswer is not null)
            {
                RightAnswer.AnswerId = rightAnswerId;

                if (AnswersList is not null)
                    RightAnswer.AnswerText = AnswersList[rightAnswerId - 1].AnswerText;
            }
        }
    }
}
