namespace AharonNoiman_UniProject;

// Represents a student in the university system.
public class Student : Person, IGraduatable
{
    // The GPA of the student.
    public double GPA { get; set; }

    // The list of courses the student is enrolled in.
    public List<string> Courses { get; } = new List<string>();

    // Initializes a new instance of the Student class.
    public Student(string id, string name, int age, double gpa) : base(id, name, age, "Student")
    {
        GPA = gpa;
    }

    // Enrolls the student in a course.
    // course - The name of the course to enroll in.
    public void EnrollCourse(string course)
    {
        Courses.Add(course);
    }

    // Retrieves detailed information about the student.
    // Returns a formatted string containing student details.
    public override string GetInfo()
    {
        return $"{Type}: {Name}, Age: {Age}, GPA: {GPA}, Courses: {string.Join(", ", Courses)}";
    }

    // Determines whether the student has met the requirements to graduate.
    // Returns true if the student's GPA is 3.0 or higher, otherwise false.
    public bool Graduate()
    {
        return GPA >= 3.0;
    }
}

