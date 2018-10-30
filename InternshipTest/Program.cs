using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = GetStudents();

            University university = new University("CH.U.I.");
            foreach (var stud in students)
                university.AddStudent(stud);

            Internship internship = new Internship("Interlink");
            foreach (var stud in university.Students)
                internship.SetStudent(stud);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());

            Console.ReadKey();
        }

        static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            Student stud = new Student("Andrew Kostenko");
            stud.SetKnowledge(new Knowledge(0));
            students.Add(stud);

            stud = new Student("Julia Veselkina");
            stud.SetKnowledge(new Knowledge(1));
            students.Add(stud);

            stud = new Student("Maria Perechrest");
            stud.SetKnowledge(new Knowledge(2));
            students.Add(stud);

            stud = new Student("Petro Ivanenko");
            stud.SetKnowledge(new Knowledge(1));
            students.Add(stud);

            stud = new Student("Dmytro Pavlyak");
            stud.SetKnowledge(new Knowledge(3));
            students.Add(stud);

            return students;
        }

    }
}
