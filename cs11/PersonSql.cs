file class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}

public class SQLPersonProcessor
{
    public static void Process(PersonDTO personDto)
    {
        var person = new Person
        {
            FirstName = personDto.FirstName,
            LastName = personDto.LastName
        }; 
        Console.WriteLine(person.FirstName+" "+person.LastName);
    }
}