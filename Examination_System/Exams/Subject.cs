using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Exams
{
    public class Subject
    {
        public event Action<Student> StudentAdded;

        public string Name { get; set; }
        List<Student> Students;
        public Subject(string name)
        {
            Name = name;
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
            StudentAdded?.Invoke(student);
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
        public void AddListOfStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                AddStudent(student);
            }
        }
        public IReadOnlyList<Student> GetAllStudents() { return Students; }
    }
}
