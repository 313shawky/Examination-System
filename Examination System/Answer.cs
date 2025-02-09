using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int AnswerId, string AnswerText)
        {
            this.AnswerId = AnswerId;
            this.AnswerText = AnswerText;
        }

        public Answer()
        {
            AnswerId = 0;
            AnswerText = string.Empty;
        }

        public override string ToString()
        {
            return $"{AnswerId}. {AnswerText}\t\t";
        }
    }
}
