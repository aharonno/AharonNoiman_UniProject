namespace AharonNoiman_UniProject;

public class ExceptionHandler
{
    // Gets a valid integer from the user, ensuring correct input.
    // prompt - The message to display for input.
    // Returns a valid integer.
    public static int GetValidInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    // Gets a valid double from the user, ensuring correct input.
    // prompt - The message to display for input.
    // Returns a valid double.
    public static double GetValidDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    // Gets a valid decimal from the user, ensuring correct input.
    // prompt - The message to display for input.
    // Returns a valid decimal.
    public static decimal GetValidDecimal(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        }
    }
}