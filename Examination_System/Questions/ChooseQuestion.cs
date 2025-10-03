using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    public abstract class ChooseQuestion : Question
    {
        public ChooseQuestion(string header, string body, int marks) : base(header, body, marks)
        { }
        public override void ShowQuestion()
        {
            Console.WriteLine(this);
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Answers[i]}");
            }
        }
    }
}
