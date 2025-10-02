using Examination_System.Answers;
using Examination_System.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Exams
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(Subject subject) : base(subject)
        {
        }


        public override void TakeExam()
        {
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                AnswersList answers = question.GetAnswer();
                UserAnswers[question] = answers;
                Console.Write($"The Right Answer Is : ");

                bool isFirstAnswer = true;
                foreach (Answer answer in question.CorrectAnswers)
                {
                    if (!isFirstAnswer) Console.Write(", ");
                    Console.Write($"{answer}"); ;
                    isFirstAnswer = false;
                }
                Console.WriteLine();

                if (UserAnswers[question].Equals(question.CorrectAnswers))
                {
                    Score += question.Marks;
                }
            }
            Console.WriteLine($"Your Score Is : {Score}\n");
        }
    }
}

