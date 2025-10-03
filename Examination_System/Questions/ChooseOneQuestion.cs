using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    public class ChooseOneQuestion : ChooseQuestion
    {
        public ChooseOneQuestion(string body, int marks) : base("Choose One Answer", body, marks)
        {
            Type = QuestionType.OneChoise;
        }


        public override AnswersList GetAnswer()
        {
            int input;
            do
            {
                Console.Write("Your Answer : ");
                input = ReadIntInput(1, Answers.Count());
            }
            while (input < 0 || input > Answers.Count);
            return new AnswersList { Answers[input - 1] };
        }

        public override object Clone()
        {
            ChooseOneQuestion question = new ChooseOneQuestion(Body, Marks);
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
