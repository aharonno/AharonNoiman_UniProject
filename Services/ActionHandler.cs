namespace AharonNoiman_UniProject;

// Handles actions related to assigning courses and subjects.
public class ActionHandler
{
    private readonly University _university;

    // Initializes a new instance of the ActionHandler class.
    // university - The university instance to manage data.
    public ActionHandler(University university)
    {
        _university = university;
    }

    // Assigns a subject to a professor or enrolls a student in a course.
    // personId - The ID of the person.
    // entry - The course name if a student, or the subject name if a professor.
    // isCourse - True if enrolling in a course, false if assigning a subject.
    public void AssignOrEnroll(string personId, string entry, bool isCourse)
    {
        Person? person = _university.FindPerson(personId);
        if (person == null)
        {
            Console.WriteLine("Person not found.");
            return;
        }

        if (isCourse && person is Student student)
        {
            if (student.Courses.Contains(entry))
            {
                Console.WriteLine($"Student is already enrolled in '{entry}'.");
                return;
            }
            student.EnrollCourse(entry);
            Console.WriteLine($"Course '{entry}' added to {student.Name}.");
        }
        else if (!isCourse && person is Professor professor)
        {
            if (professor.SubjectsTaught.Contains(entry))
            {
                Console.WriteLine($"Professor already teaches '{entry}'.");
                return;
            }
            professor.AssignSubject(entry);
            Console.WriteLine($"Subject '{entry}' assigned to {professor.Name}.");
        }
        else
        {
            Console.WriteLine("Invalid operation for this person type.");
        }
    }
}
