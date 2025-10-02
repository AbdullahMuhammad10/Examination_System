using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Answers
{
    internal class Answer : IComparable<Answer>, ICloneable
    {
        public Answer(string answer, bool isCorrect = false)
        {
            Body = answer;
            IsCorrect = isCorrect;
        }
        public string Body { get; set; }
        public bool IsCorrect { get; set; }
        public override string ToString()
        {
            return Body;
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Answer answer) return false;
            return string.Equals(Body.Trim(), answer.Body.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Body.GetHashCode();
        }

        public object Clone()
        {
            return new Answer(Body, IsCorrect);
        }

        public int CompareTo(Answer? other)
        {
            return Body.CompareTo(other.Body);
        }
    }
}
