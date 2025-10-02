using Examination_System.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    public enum QuestionType
    {
        TF,
        OneChoise,
        MultiChoise
    }
    internal abstract class Question : IComparable<Question>, ICloneable
    {
        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswersList();
        }
        public string Header { get; private set; }
        public string Body { get; private set; }
        public int Marks { get; private set; }
        public QuestionType Type { get; set; }
        public AnswersList Answers { get; set; }
        public AnswersList CorrectAnswers
        {
            get
            {
                return new AnswersList(Answers.Where(a => a.IsCorrect));
            }
        }

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

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return Body.CompareTo(other.Body);
        }

        public abstract object Clone();
    }

}
