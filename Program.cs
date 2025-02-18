using System;

namespace AharonNoiman_UniProject;

public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the university
        University university = new University();

        // Create an instance of the menu handler with the university instance
        MenuHandler menuHandler = new MenuHandler(university);

        // Start the menu interaction
        menuHandler.Start();
    }
}
