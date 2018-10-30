using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipTest
{
    public class Internship
    {
        public string Name { get; set; }
        protected List<Student> Students { get; set; }

        public Internship(String name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void SetStudent(Student student)
        {
            if (student.Knowledge == KnowledgeLevel.BelowAverage || 
                student.Knowledge == KnowledgeLevel.High)
            {
                Students.Add(student);
            }
        }

        public string GetStudents()
        {
            return Students.Aggregate(string.Empty, (a, b) => a + b.Name + "\n"); ;
        }

    }
}
