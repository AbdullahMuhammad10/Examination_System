using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    public class TFQuestion : Question
    {
        public TFQuestion(string body, int marks) : base("True OR False", body, marks)
        {
            Type = QuestionType.TF;
        }

        public override AnswersList GetAnswer()
        {
            int input;
            do
            {
                Console.Write("Your Answer (1,2) : ");
                input = ReadIntInput(1, Answers.Count());
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

        public override object Clone()
        {
            TFQuestion question = new TFQuestion(Body, Marks);
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
