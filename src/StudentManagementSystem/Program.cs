using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

StudentService service = new();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Student Management System");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Save");
    Console.WriteLine("6. Exit");

    Console.Write("Choice: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            try
            {
                Console.Write("ID: ");
                int id =
                    int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name =
                    Console.ReadLine();

                Console.Write("Age: ");
                int age =
                    int.Parse(Console.ReadLine());

                Console.Write("Course: ");
                string course =
                    Console.ReadLine();

                Student student =
                    new(id, name, age, course);

                service.Add(student);

                Console.WriteLine(
                    "Student Added.");
            }
            catch
            {
                Console.WriteLine(
                    "Invalid Input.");
            }

            break;

        case "2":

            foreach (var student in service.GetAll())
            {
                student.Display();
            }

            break;

        case "3":

            Console.Write(
                "Enter Student ID: ");

            int searchId =
                int.Parse(Console.ReadLine());

            var found =
                service.FindStudent(searchId);

            if (found != null)
                found.Display();
            else
                Console.WriteLine(
                    "Student Not Found");

            break;

        case "4":

            Console.Write(
                "Enter ID: ");

            int deleteId =
                int.Parse(Console.ReadLine());

            service.Delete(deleteId);

            Console.WriteLine(
                "Deleted.");

            break;

        case "5":

            FileService.SaveStudents(
                @"Data\students.txt",
                service.GetAll());

            Console.WriteLine(
                "Saved.");

            break;

        case "6":

            running = false;
            break;

        default:

            Console.WriteLine(
                "Invalid Choice");
            break;
    }
}
