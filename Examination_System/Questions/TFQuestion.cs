using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    internal class TFQuestion : Question
    {
        public TFQuestion(string body, int marks) : base("True OR False", body, marks)
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

            AnswersList answers = new AnswersList { Answers[input - 1] };
            return answers;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(this);
            Console.WriteLine("1.True - 2.False");
        }
    }
}
