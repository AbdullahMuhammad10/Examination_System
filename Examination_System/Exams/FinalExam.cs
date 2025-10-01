using Examination_System.Answers;
using Examination_System.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Examination_System.Exams
{
    internal class FinalExam : Exam
    {
        public FinalExam(Subject subject) : base(subject)
        {
        }

        public override void ShowExam()
        {

        }

        public override void TakeExam()
        {
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                AnswersList answers = question.GetAnswer();
                UserAnswers[question] = answers;
                foreach (var answer in answers)
                {
                    if (answer.IsCorrect)
                    {
                        Score += question.Marks;
                    }
                }

            }
            Console.WriteLine($"Your Score Is : {Score}");
        }

    }
}
