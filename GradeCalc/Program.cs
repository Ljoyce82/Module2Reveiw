using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace GradeCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Student> Students = new List<Student>();

            Student Jim = new Student(1, "Jim"); ///added this cause and method in student class to get it to print names otherwise was always 0 blank grades..
            Student Bob = new Student(2, "Bob");
            Student Billy = new Student(3, "Billy");
            Student Chet = new Student(4, "Chet");

            Students.Add(Jim);
            Students.Add(Bob);
            Students.Add(Billy);
            Students.Add(Chet);

            Students[0].AddGrade(94.3);
            Students[0].AddGrade(45.6, 67.1, 74.9);
            Students[1].AddGrade(67.2);
            Students[1].AddGrade(0, 67.1, 71.1);
            Students[2].AddGrade(56.4);
            Students[2].AddGrade(45.6, 65.0, 22.1);
            Students[3].AddGrade(87.1);
            Students[3].AddGrade(45.6, 0, 71.1);

            foreach (Student student in Students)
            {
                double averageGrade = student.CalculateAverageGrade();
                Console.WriteLine($"{student.Id} {student.Name} Grades: {string.Join(", ", student.Grades)} Average: {averageGrade}");
            }
        }
    }
}
