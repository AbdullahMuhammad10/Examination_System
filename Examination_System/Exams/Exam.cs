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
    internal abstract class Exam
    {
        public event Action<string>? ExamStarting;
        protected Exam(Subject subject)
        {
            Subject = subject;
            UserAnswers = new Dictionary<Question, AnswersList>();
            Questions = new QuestionsList();
            Subject.StudentAdded += (student) => ExamStarting += student.NotifyExam;
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

        public abstract void ShowExam();
        public abstract void TakeExam();

    }
    public enum ExamMode { Starting, Queued, Finished }
}
