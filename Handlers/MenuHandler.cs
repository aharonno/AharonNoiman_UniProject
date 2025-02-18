namespace AharonNoiman_UniProject;

public class MenuHandler
{
    private readonly University _university;
    private readonly ActionHandler _actionHandler;

    // Initializes a new instance of the MenuHandler class.
    // university - The university instance to manage.
    public MenuHandler(University university)
    {
        _university = university;
        _actionHandler = new ActionHandler(university);
    }

    // Starts the menu loop, handling user choices.
    public void Start()
    {
        _university.LoadFromFile();
        try
        {
            while (true)
            {
                Console.WriteLine("\nUniversity Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Professor");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. Assign Subject to Professor");
                Console.WriteLine("5. Display All People");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "1":
                        // Adds a new student to the university
                        _university.AddPerson(UserInputHandler.CreatePerson("Student"));
                        break;
                    case "2":
                        // Adds a new professor to the university
                        _university.AddPerson(UserInputHandler.CreatePerson("Professor"));
                        break;
                    case "3":
                        // Enrolls a student in a course
                        Console.Write("Enter Student ID: ");
                        string studentId = Console.ReadLine()!;
                        Console.Write("Enter Course Name: ");
                        string courseName = Console.ReadLine()!;
                        _actionHandler.AssignOrEnroll(studentId, courseName, true);
                        break;
                    case "4":
                        // Assigns a subject to a professor
                        Console.Write("Enter Professor ID: ");
                        string professorId = Console.ReadLine()!;
                        Console.Write("Enter Subject Name: ");
                        string subjectName = Console.ReadLine()!;
                        _actionHandler.AssignOrEnroll(professorId, subjectName, false);
                        break;
                    case "5":
                        // Displays all registered people in the university
                        _university.DisplayAllPeople();
                        break;
                    case "6":
                        // Saves university data and exits the application
                        _university.SaveToFile();
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}
