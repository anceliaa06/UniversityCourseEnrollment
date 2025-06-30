using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityCourseEnrollment
{
    class InPersonCourse : Course
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }

        // Constructor to initialize course name, instructor, room number, and capacity
        public InPersonCourse(string courseName, string instructor, string roomNumber, int capacity)
        : base(courseName, instructor)
        {
            //IsNullOrWhiteSpace checks if the string is null, empty, or consists only of white-space characters.
            if (string.IsNullOrWhiteSpace(roomNumber))
                Console.WriteLine("Room number is required for in-person courses.");
            if (capacity <= 0)
                Console.WriteLine("Capacity must be greater than zero.");

            RoomNumber = roomNumber;
            Capacity = capacity;
        }
        public override void EnrollStudent(string studentName)
        {
            Console.WriteLine($"Enrolling {studentName} in in-person course: {CourseName} taught by {Instructor} in room {RoomNumber} with capacity {Capacity}.");
        }
    }
    
}
