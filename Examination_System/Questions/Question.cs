using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    internal abstract class Question
    {
        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }
        public string Header { get; private set; }
        public string Body { get; private set; }
        public int Marks { get; private set; }
        public AnswersList Answers { get; set; } = new AnswersList();

        public abstract void ShowQuestion();
        public abstract AnswersList GetAnswer();
        public override string ToString()
        {
            return $"{Header} (Marks:{Marks}) :: {Body} ?";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Body, Header);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Question question = obj as Question;
            return this.Body == question.Body;
        }

    }
}
