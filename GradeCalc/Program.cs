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

            Student Jim = new Student();
            Student Bob= new Student();
            Student Billy = new Student();
            Student Chet = new Student();

            Students.Add(Jim);
            Students.Add(Bob);
            Students.Add(Chet);
            Students.Add(Bob);

        }
    }
}
