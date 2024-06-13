public class MethodGroup
{
    public static void IndexerAccess()
    {
       List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbers  = numbers.Where(IsEven).ToList();
        evenNumbers.ForEach(Console.Write);
        Console.WriteLine();
    }
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}