using Newtonsoft.Json;

// Install-Package Newtonsoft.Json //NuGet Package Manager

namespace AharonNoiman_UniProject;

// Manages university operations, including storing and retrieving persons.
public class University
{
    private readonly Dictionary<string, Person> people = new Dictionary<string, Person>();
    private readonly string FilePath;

    // Initializes a new instance of the University class.
    // filePath - The file path for data storage.
    public University(string filePath = "university_data.json")
    {
        FilePath = filePath;
        LoadFromFile();
    }

    // Adds a person to the university.
    // person - The person to add.
    public void AddPerson(Person person)
    {
        if (people.ContainsKey(person.Id))
        {
            Console.WriteLine("Error: ID already exists.");
            return;
        }
        people[person.Id] = person;
        SaveToFile();
        Console.WriteLine("Person added successfully.");
    }

    // Finds a person by their ID.
    // id - The ID of the person to find.
    // Returns the found Person or null if not found.
    public Person? FindPerson(string id)
    {
        return people.TryGetValue(id, out Person? person) ? person : null;
    }

    // Displays all people in the university.
    public void DisplayAllPeople()
    {
        foreach (Person person in people.Values)
        {
            Console.WriteLine(person.GetInfo());
        }
    }

    // Saves the current data to a file.
    public void SaveToFile()
    {
        try
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(people, Formatting.Indented, settings));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving data: {ex.Message}");
        }
    }

    // Loads data from a file.
    public void LoadFromFile()
    {
        try
        {
            if (File.Exists(FilePath))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                string json = File.ReadAllText(FilePath);
                Dictionary<string, Person>? loadedPeople = JsonConvert.DeserializeObject<Dictionary<string, Person>>(json, settings);

                if (loadedPeople != null)
                {
                    people.Clear();
                    foreach (KeyValuePair<string, Person> person in loadedPeople)
                    {
                        try
                        {
                            string validatedId = Validation.ValidateId(person.Key);
                            people[validatedId] = person.Value;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error loading data for ID {person.Key}: {ex.Message}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
