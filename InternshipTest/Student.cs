using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipTest
{
    public class Student
    {
        public string Name { get; }
        public KnowledgeLevel Knowledge { get; protected set; }

        public Student(String name)
        {
            Name = name;
            SetKnowledge(new Knowledge(0));
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            Knowledge = knowledge.KnowledgeLevel;           
        }

    }
}
