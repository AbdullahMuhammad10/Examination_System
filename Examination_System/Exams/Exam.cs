using Examination_System.Answers;
using Examination_System.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Exams
{
    public abstract class Exam
    {
        public event Action<string>? ExamStarting;
        public event Action<string>? ExamFinished;
        protected Exam(Subject subject)
        {
            Subject = subject;
            UserAnswers = new Dictionary<Question, AnswersList>();
            Questions = new QuestionsList();

            // For Coming Students
            Subject.StudentAdded += (student) => ExamStarting += student.NotifyExam;
            Subject.StudentAdded += (student) => ExamFinished += student.NotifyExam;

            // For AlreadyExcited Students
            foreach (var student in Subject.GetAllStudents())
            {
                ExamStarting += student.NotifyExam;
                ExamFinished += student.NotifyExam;
            }
        }
        public int Score { get; protected set; }
        public QuestionsList Questions { get; set; }
        public Dictionary<Question, AnswersList> UserAnswers { get; set; }
        public Subject Subject { get; set; }
        public ExamMode Mode { get; set; }
        public void StartExam()
        {
            Mode = ExamMode.Starting;
            ExamStarting?.Invoke($"{Subject.Name} Exam Started.");
        }
        public void FinishExam()
        {
            Mode = ExamMode.Finished;
            ExamStarting?.Invoke($"{Subject.Name} Exam Finished.");
        }

        public void ShowExam()
        {
            foreach (Question question in Questions)
            {
                Console.WriteLine(question);
                Console.Write("The Correct Answer(s): ");
                bool isFirst = true;
                foreach (Answer answer in question.CorrectAnswers)
                {
                    if (!isFirst) Console.Write(", ");
                    Console.Write(answer);
                    isFirst = false;
                }
                Console.WriteLine("\n");
            }
        }
        public abstract void TakeExam();

    }
    public enum ExamMode { Starting, Queued, Finished }
}
