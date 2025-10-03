global using static Examination_System.Helper;

using Examination_System.Answers;
using Examination_System.Exams;
using Examination_System.Questions;
using System.Net.Quic;

namespace Examination_System
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Subject> subjects = InitializeSubjects();

            Console.WriteLine("Please Choose Exam Subject (1.OOP, 2.Math): ");
            int subjectChoice = ReadIntInput();
            Subject chosenSubject = subjects[subjectChoice - 1];

            Console.WriteLine("Please Choose Exam Type (1.Practical, 2.Final): ");
            int examChoice = ReadIntInput();

            QuestionsList questions = QuestionBank.GetQuestions(chosenSubject.Name);

            RunExam(chosenSubject, questions, examChoice);


        }




    }
}


