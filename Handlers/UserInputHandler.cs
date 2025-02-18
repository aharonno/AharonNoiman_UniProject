namespace AharonNoiman_UniProject;

public static class UserInputHandler
{
    // Gets a valid, non-empty ID from the user.
    // Returns a valid ID string.
    public static string GetValidId()
    {
        while (true)
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine()!.Trim();
            if (!string.IsNullOrEmpty(id))
                return id;

            Console.WriteLine("Invalid input. ID cannot be empty.");
        }
    }

    // Gets a valid, non-empty string input from the user.
    // prompt - The message to display for input.
    // Returns a valid non-empty string.
    public static string GetValidString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine()!.Trim();
            if (!string.IsNullOrEmpty(input))
                return input;

            Console.WriteLine("Invalid input. Please enter a valid text.");
        }
    }

    // Creates a new Person (Student or Professor) based on user input.
    // type - The type of person to create ("Student" or "Professor").
    // Returns a newly created Person object.
    // Throws ArgumentException if an invalid type is provided.
    public static Person CreatePerson(string type)
    {
        string id = GetValidId();
        string name = GetValidString("Enter Name: ");
        int age = ExceptionHandler.GetValidInt("Enter Age: ");

        return type switch
        {
            "Student" => new Student(id, name, age, ExceptionHandler.GetValidDouble("Enter GPA: ")),
            "Professor" => new Professor(id, name, age, ExceptionHandler.GetValidDecimal("Enter Salary: ")),
            _ => throw new ArgumentException("Invalid person type.")
        };
    }
}

