using Examination_System.Answers;
using Examination_System.Exams;
using Examination_System.Questions;
using System.Net.Quic;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject("OOP"); // init Subject OOP
            s1.AddListOfStudents(new List<Student>() {
                    new Student("Abdullah"),
                    new Student("Mahmoud")}
           );

            Subject s2 = new Subject("MVC");  // init Subject MVC
            s2.AddListOfStudents(new List<Student>() {
                    new Student("Mohamed"),
                    new Student("Ahmed")
                });

            Subject s3 = new Subject("Advanced C#"); // init Subject Advanced C#
            s3.AddListOfStudents(new List<Student>() {
                    new Student("Mazin"),
                    new Student("Eman")
                });

            // init First Question And it's Answers
            AnswersList firstQAnswers = new AnswersList();
            firstQAnswers.Add(new Answer("True", false));
            firstQAnswers.Add(new Answer("False", true));
            TFQuestion firstQ = new TFQuestion("Is 10 < 15", 2) { Answers = firstQAnswers };

            // init Second Question And it's Answers
            AnswersList secondQAnswers = new AnswersList();
            secondQAnswers.Add(new Answer("Yes", true));
            secondQAnswers.Add(new Answer("No", false));
            ChooseOneQuestion secondQ = new ChooseOneQuestion("Is 1+1 = 2", 2) { Answers = secondQAnswers };

            // init Third Question And it's Answers
            AnswersList thirdQAnswers = new AnswersList();
            thirdQAnswers.Add(new Answer("2", true));
            thirdQAnswers.Add(new Answer("70", true));
            thirdQAnswers.Add(new Answer("13"));
            thirdQAnswers.Add(new Answer("102", true));
            ChooseAllQuestion thirdQ = new ChooseAllQuestion("Which Is a Even Number", 2) { Answers = thirdQAnswers };

            PracticeExam p = new PracticeExam(s1);
            p.Questions.Add(firstQ);
            p.Questions.Add(secondQ);
            p.Questions.Add(thirdQ);

            FinalExam f = new FinalExam(s2);
            f.Questions.Add(firstQ);
            f.Questions.Add(secondQ);
            f.Questions.Add(thirdQ);
            Console.WriteLine("Please Choose Exam Type (1.Parctical,2.Final)");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                p.StartExam();
                p.TakeExam();
            }
            else if (choise == 2)
            {
                f.StartExam();
                f.TakeExam();
            }

            //Console.WriteLine(question);
        }
    }
}
