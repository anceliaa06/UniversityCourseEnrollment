namespace UniversityCourseEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter course type (online / inperson / lab):");
            string type = Console.ReadLine().ToLower();

            Console.WriteLine("Enter course name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter instructor name:");
            string instructor = Console.ReadLine();

            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();

            switch (type)
            {
                case "online":
                    Console.WriteLine("Enter video platform link:");
                    string link = Console.ReadLine();
                    // Validate that the link is not null or empty
                    if (!string.IsNullOrWhiteSpace(link))
                    {
                        Course online = new OnlineCourse(name, instructor, link);
                        online.EnrollStudent(studentName);
                    }
                    else
                    {
                        Console.WriteLine("Enrollment failed: Video platform link is required.");
                    }
                    break;

                case "inperson":
                    Console.WriteLine("Enter room number:");
                    string room = Console.ReadLine();
                    
                    Console.WriteLine("Enter capacity:");
                    if (int.TryParse(Console.ReadLine(), out int capacity) && capacity > 0 && !string.IsNullOrWhiteSpace(room))
                    {
                        Course inPerson = new InPersonCourse(name, instructor, room, capacity);
                        inPerson.EnrollStudent(studentName);
                    }
                    else
                    {
                        Console.WriteLine("Enrollment failed: Valid room number and capacity are required.");
                    }
                    break;

                case "lab":
                    Console.WriteLine("Has safety training been completed? (yes/no):");
                    string input = Console.ReadLine();
                    bool safetyCompleted = input == "yes";

                    if (safetyCompleted)
                    {
                        Course lab = new LabCourse(name, instructor, true);
                        lab.EnrollStudent(studentName);
                    }
                    else
                    {
                        Console.WriteLine("Enrollment failed: Safety training must be completed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid course type.");
                    break;
            }
        }
    }
    }

