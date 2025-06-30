using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    internal class OnlineCourse : Course
    {
        public string VideoPltformLink { get; set; }

        // Constructor to initialize course name, instructor, and video platform link
        public OnlineCourse(string courseName, string instructor, string videoPlatformLink)
        : base(courseName, instructor)
        {
            // Check if the video platform link is null or empty
            if (string.IsNullOrEmpty(videoPlatformLink))

                Console.WriteLine("Video platform link cannot be null or empty.");

            videoPlatformLink = videoPlatformLink;
        }

            public override void EnrollStudent(string studentName)
            {
            Console.WriteLine($"Enrolling {studentName} in online course: {CourseName} taught by {Instructor}.");
        }
    }
    }
    

