using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Questions
{
    internal class QuestionsList : HashSet<Question>
    {
        public new void Add(Question question)
        {
            base.Add(question);
            using (TextWriter writer = new StreamWriter($"{question.Type}Questions.txt", true))
            {
                writer.WriteLine(question);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
