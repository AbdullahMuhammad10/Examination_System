using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Answers
{
    public class AnswersList : List<Answer>
    {
        public AnswersList()
        {

        }
        public AnswersList(IEnumerable<Answer> answers) : base(answers) { }

        public override bool Equals(object? obj)
        {
            if (obj is not AnswersList answers) return false;
            return this.Count == answers.Count &&
                   this.All(a => answers.Contains(a));
            // && answers.All(a => this.Contains(a)); // Not Nessasary Any More Because Count Check

        }
    }

}
