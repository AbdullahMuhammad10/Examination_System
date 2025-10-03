using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name) => Name = name;

        public void NotifyExam(string msg)
        {
            Console.WriteLine($"Student {Name} received notification: {msg}");
        }
    }
}
