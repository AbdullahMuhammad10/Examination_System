using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    internal class ChooseOneQuestion : ChooseQuestion
    {
        public ChooseOneQuestion(string body, int marks) : base("Choose One Answer", body, marks)
        {

        }

        public override AnswersList GetAnswer()
        {
            int input;
            do
            {
                Console.Write("Your Answer (1,2) : ");
                input = int.Parse(Console.ReadLine());
            }
            while (input < 0 || input > Answers.Count);
            return new AnswersList { Answers[input - 1] };
        }

    }
}
