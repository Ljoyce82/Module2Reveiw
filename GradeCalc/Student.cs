using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    public class Student
    {
        string Name {  get; set; }
        int Id { get; set; }
        List<double> Grades { get; } = new List<double>();

        
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
