using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    abstract class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        //constructor to initialize course name and instructor
        public Course(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public abstract void EnrollStudent(string studentName);
    }
}
