using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    class Student
    {
        public string Name {  get; set; }
        public int Id { get; set; }

        public List<double> Grades = new List<double>();

        public Student(int id, string name)//as expalined in program added for id name issue
        {
            Id = id;
            Name = name;
            Grades = new List<double>();
        }


        public void AddGrade(double grade)
        {
            Grades.Add(grade);
        }

        public void AddGrade(params double[] grades) 
        {
            Grades.AddRange(grades);
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0)
            {
                return 0;
            }
            double total = 0;
            foreach (double grade in Grades)
            {
                total += grade;
            }
            return total / Grades.Count;
        }
    }

}
