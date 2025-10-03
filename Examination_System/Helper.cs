using Examination_System.Answers;
using Examination_System.Exams;
using Examination_System.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public static class Helper
    {
        public static List<Subject> InitializeSubjects()
        {
            var s1 = new Subject("OOP");
            s1.AddListOfStudents(new List<Student> { new Student("Abdullah"), new Student("Mahmoud") });

            var s2 = new Subject("Math");
            s2.AddListOfStudents(new List<Student> { new Student("Mohamed"), new Student("Ahmed") });

            return new List<Subject> { s1, s2 };
        }
        public static QuestionsList CreateMathQuestions()
        {
            return new QuestionsList
            {
                new TFQuestion("2.23 Is Greater Than 2.6", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("True"),
                        new Answer("False", true)
                    }
                },
                new ChooseOneQuestion("7 * 8 = ...", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("49"),
                        new Answer("64"),
                        new Answer("56", true),
                        new Answer("48")
                    }
                },
                new ChooseAllQuestion("Which Of These Is Prime Number", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("7", true),
                        new Answer("31", true),
                        new Answer("15"),
                        new Answer("13", true)
                    }
                }
            };
        }

        public static QuestionsList CreateOOPQuestions()
        {
            return new QuestionsList
            {
                new TFQuestion("Sealed Class Doesn't Allow Inheritance", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("True", true),
                        new Answer("False", false)
                    }
                },
                new ChooseOneQuestion("Which Data Type Can Store Numeric Data", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("Char"),
                        new Answer("Int", true),
                        new Answer("Enum"),
                        new Answer("Delegate")
                    }
                },
                new ChooseAllQuestion("Which Of These Is Access Modifier", 2)
                {
                    Answers = new AnswersList
                    {
                        new Answer("Private", true),
                        new Answer("public", true),
                        new Answer("Secret"),
                        new Answer("Public", true)
                    }
                }
            };
        }
        public static void RunExam(Subject subject, QuestionsList questions, int examChoice)
        {
            Exam exam = examChoice == 1 ? new PracticeExam(subject) : new FinalExam(subject);

            exam.Questions.AddRange(questions);
            exam.StartExam();
            exam.TakeExam();
            exam.FinishExam();

            Console.Write("Do You Want To See All Right Answers? (Y/N): ");
            if (Console.ReadLine()?.Trim().ToLower() == "y")
            {
                exam.ShowExam();
            }
        }

        public static int ReadIntInput(int min = 1, int max = 2)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                    return value;

                Console.Write($"Invalid choice, please enter a number between {min} and {max}: ");
            }
        }
        public static class QuestionBank // This Class Is Ai Generated To help to make My Code Simple 🙏🏻
        {
            public static QuestionsList GetQuestions(string subjectName)
            {
                return subjectName.ToLower() switch
                {
                    "oop" => CreateOOPQuestions(),
                    "math" => CreateMathQuestions(),
                    _ => new QuestionsList()
                };
                //if (subjectName.ToLower() == "math") return CreateMathQuestions();
                //else if (subjectName.ToLower() == "oop") return CreateOOPQuestions();
                //else return new QuestionsList();

                //switch (subjectName.ToLower())
                //{
                //    case "oop":
                //    return CreateOOPQuestions();
                //    case "math":
                //    return CreateMathQuestions();
                //    default:
                //    return new QuestionsList();
                //}


            }

        }
    }
}
