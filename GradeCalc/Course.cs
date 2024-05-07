using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }

        private List<string> EnrolledStudents { get; set; }

        public Course()
        {
            EnrolledStudents = new List<string>();
        }

        public void EnrollStudents(string Name)
        {
            if (!EnrolledStudents.Contains(Name))
            {
                EnrolledStudents.Add(Name);
                Console.WriteLine($"{Name} has been enrolled in the course");
            }
            else
            {
                Console.WriteLine($"{Name} is already in that course");
            }
        }

        public void DisplayCourseInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine("Enrolled Student:");

            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"{student}");
            }
        }
  
      }
}
     




