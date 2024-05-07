using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalc
{
    class Course
    {
        public string CourseName { get; set; } //set properties for class to use
        public string CourseCode { get; set; }

        private List<string> EnrolledStudents { get; set; }

        public Course()
        {
            EnrolledStudents = new List<string>(); //list for students in each course
        }

        public void EnrollStudents(string Name) //method to enroll student
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

        public void DisplayCourseInfo() //constructor for courses
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
     




