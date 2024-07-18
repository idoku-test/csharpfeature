using System.Diagnostics.CodeAnalysis;
public class Car
{
    public required string Name { get; set; }
    public required int BrandId { get; set; }

    [SetsRequiredMembers]
    public Car(string name)
    {
        Name = name;
    }
}

public class Motor
{
    public required string Name { get; set; }
    public required int BrandId { get; set; }

    public Motor(string name)
    {
        Name = name;
    }
}