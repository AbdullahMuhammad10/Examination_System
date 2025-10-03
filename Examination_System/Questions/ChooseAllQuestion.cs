using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    public class ChooseAllQuestion : ChooseQuestion
    {

        public ChooseAllQuestion(string body, int marks) : base("Choose All Correct Answer", body, marks)
        {
            Type = QuestionType.MultiChoise;
        }

        public override AnswersList GetAnswer()
        {

            Console.Write("Please Choose Every Correct Answer Separeted By Comma: ");
            string input = Console.ReadLine();
            string[] ans = input.Split(",");
            AnswersList answers = new AnswersList();

            foreach (string answer in ans)
            {
                answers.Add(Answers[int.Parse(answer.Trim()) - 1]);
            }
            return answers;

        }
        public override object Clone()
        {
            ChooseAllQuestion question = new ChooseAllQuestion(Body, Marks);
            foreach (Answer answer in Answers)
            {
                question.Answers.Add(answer);
            }
            foreach (Answer answer in CorrectAnswers)
            {
                question.CorrectAnswers.Add(answer);
            }
            return question;
        }
    }
}
