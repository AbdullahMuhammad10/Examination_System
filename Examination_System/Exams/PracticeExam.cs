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

                Console.Write($"The Right Answer Is : ");
                bool isFirstAnswer = true;
                foreach (Answer answer in question.Answers)
                {
                    if (answer.IsCorrect)
                    {
                        if (!isFirstAnswer) Console.Write(", ");
                        Console.Write($"{answer}"); ;
                        isFirstAnswer = false;
                    }
                }
                Console.WriteLine();
                //foreach (Answer answer in answers)
                //{
                //    if (answer.IsCorrect)
                //    {
                //        Score += question.Marks;
                //    }
                //}
                bool allCorrect = true;

                // Check if user missed any correct answer
                foreach (var correct in question.Answers)
                {
                    if (correct.IsCorrect)
                    {
                        bool found = false;
                        foreach (var userAnswer in answers)
                        {
                            if (string.Equals(correct.Body.Trim(), userAnswer.Body.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            allCorrect = false;
                            break;
                        }
                    }
                }

                // Check if user chose any wrong answer
                if (allCorrect)
                {
                    foreach (var userAnswer in answers)
                    {
                        bool matched = false;
                        foreach (var correct in question.Answers)
                        {
                            if (correct.IsCorrect &&
                                string.Equals(correct.Body.Trim(), userAnswer.Body.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                matched = true;
                                break;
                            }
                        }
                        if (!matched)
                        {
                            allCorrect = false;
                            break;
                        }
                    }
                }

                if (allCorrect)
                {
                    Score += question.Marks;
                }
            }
            Console.WriteLine($"Your Score Is : {Score}");
        }
    }
}
