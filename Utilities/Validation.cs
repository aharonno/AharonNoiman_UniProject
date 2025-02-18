using System.Text.RegularExpressions;

namespace AharonNoiman_UniProject;

// Utility class for validation to provide immediate feedback.
public static class Validation
{
    public static string ValidateId(string id)
    {
        while (true)
        {
            if (Regex.IsMatch(id, @"^\d{9}$")) return id;
            Console.Write("Invalid ID! Please enter a 9-digit ID: ");
            id = Console.ReadLine() ?? "";
        }
    }

    public static string ValidateName(string name)
    {
        while (true)
        {
            if (Regex.IsMatch(name, @"^[A-Za-z]")) return name;
            Console.Write("Invalid Name! Please enter a valid name (only letters): ");
            name = Console.ReadLine() ?? "";
        }
    }

    public static int ValidateAge(int age)
    {
        while (true)
        {
            if (age >= 18 && age <= 120) return age;
            Console.Write("Invalid Age! Please enter an age between 18 and 120: ");
            int.TryParse(Console.ReadLine(), out age);
        }
    }

    public static decimal ValidateSalary(decimal salary)
    {
        while (true)
        {
            if (salary >= 0) return salary;
            Console.Write("Invalid Salary! Please enter a non-negative salary: ");
            decimal.TryParse(Console.ReadLine(), out salary);
        }
    }
}
