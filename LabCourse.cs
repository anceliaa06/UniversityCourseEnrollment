using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    class LabCourse : Course
    {
        
        public bool SafetyTrainingCompleted { get; set; }

        // Constructor to initialize course name, instructor, and safety training status
        public LabCourse(string courseName, string instructor, bool safetyTrainingCompleted)
        : base(courseName, instructor)
        {
            // Check if safety training is completed for lab courses
            if (!safetyTrainingCompleted)
                Console.WriteLine("Safety training must be completed for lab courses.");
            
            SafetyTrainingCompleted = safetyTrainingCompleted;
        }

        
        public override void EnrollStudent(string studentName)
        {
            Console.WriteLine($"Enrolling student {studentName} in lab course: {CourseName} taught by {Instructor}. Safety training completed: {SafetyTrainingCompleted}.");
        }
    }
    
}
