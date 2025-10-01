using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    internal class ChooseAllQuestion : ChooseQuestion
    {
        public ChooseAllQuestion(string body, int marks) : base("Choose All Correct Answer", body, marks)
        {

        }

        public override AnswersList GetAnswer()
        {

            Console.Write("Please Choose Every Correct Answer Separeted By Comma: ");
            string input = Console.ReadLine();
            string[] ans = input.Split(",");
            AnswersList answers = new AnswersList();
            foreach (string answer in ans)
            {
                answers.Add(new Answer(answer));
            }
            return answers;
        }
    }
}
