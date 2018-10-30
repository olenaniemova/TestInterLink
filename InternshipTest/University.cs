using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipTest
{
    public class University
    {
        public string Name { get; set; }
        public List<Student> Students { get; }

        public University(String name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void SetStudent(Student student)
        {
            int knowLevel = (int)student.Knowledge;
            knowLevel += 2;
            if (knowLevel >= 4) student.SetKnowledge(new Knowledge(4));
            else student.SetKnowledge(new Knowledge(knowLevel));
        }

        public void AddStudent(Student student)
        {
            SetStudent(student);
            Students.Add(student);            
        }

    }
}
