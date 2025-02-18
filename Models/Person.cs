namespace AharonNoiman_UniProject;

// Represents a person in the university system.
public abstract class Person
{
    // Unique identifier for the person.
    public string Id { get; }

    // The full name of the person.
    public string Name { get; set; }

    // The age of the person.
    public int Age { get; set; }

    // The type of person (e.g., Student, Professor).
    public string Type { get; }

    // Initializes a new instance of the Person class.
    protected Person(string id, string name, int age, string type)
    {
        Id = Validation.ValidateId(id);
        Name = Validation.ValidateName(name);
        Age = Validation.ValidateAge(age);
        Type = type;
    }

    // Retrieves detailed information about the person.
    // Returns a formatted string containing person details.
    public abstract string GetInfo();
}
