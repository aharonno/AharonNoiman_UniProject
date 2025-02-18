namespace AharonNoiman_UniProject;

// Represents a professor in the university system.
public class Professor : Person
{
    // The salary of the professor.
    public decimal Salary { get; set; }

    // The list of subjects taught by the professor.
    public List<string> SubjectsTaught { get; } = new List<string>();

    // Initializes a new instance of the Professor class.
    public Professor(string id, string name, int age, decimal salary) : base(id, name, age, "Professor")
    {
        Salary = Validation.ValidateSalary(salary); 
    }

    // Assigns a subject to the professor.
    // subject - The subject to be assigned.
    public void AssignSubject(string subject)
    {
        SubjectsTaught.Add(subject);
    }

    // Retrieves detailed information about the professor.
    // Returns a formatted string containing professor details.
    public override string GetInfo()
    {
        return $"{Type}: {Name}, Age: {Age}, Salary: {Salary}, Subjects: {string.Join(", ", SubjectsTaught)}";
    }
}