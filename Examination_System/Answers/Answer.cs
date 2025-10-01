using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Answers
{
    internal class Answer
    {
        public Answer(string answer, bool isCorrect = false)
        {
            Body = answer;
            IsCorrect = isCorrect;
        }
        public string Body { get; set; }
        public bool IsCorrect { get; set; }
        public override string ToString()
        {
            return Body;
        }
    }
}
