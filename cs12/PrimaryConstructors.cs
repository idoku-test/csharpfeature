
public class  Person(string firstName,string lastName)
{
    public  string FullName => $"{firstName}-{lastName}";

    public void Print(){
        Console.WriteLine(FullName);
    }
}

public readonly struct Distance(double dx,double dy)
{
    public readonly double Magnitude = Math.Sqrt(dx * dx + dy * dy);
    public readonly double Direction = Math.Atan2(dy, dx);

    public void Print(){
        Console.WriteLine($"Magnitude:{Magnitude},Direction:{Direction}");
    }
}