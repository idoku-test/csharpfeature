file class Person
{
    public string? FirstNameLastName { get; set; }
}

public class HttpPersonProcessor
{
    public static void Process(PersonDTO personDto)
    {
        var person = new Person
        {
            FirstNameLastName = $"{personDto.FirstName} {personDto.LastName}"
        };        
        Console.WriteLine(person.FirstNameLastName);
    }
}