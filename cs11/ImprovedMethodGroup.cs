
public class ImprovedMethodGroup
{
   static readonly List<int> Numbers = Enumerable.Range(0, 100).ToList();

    public static int Sum()
    {
        return Numbers.Where(x => Filter(x)).Sum(); // <- faster
    }

    public static int SumMethodGroup()
    {
        return Numbers.Where(Filter).Sum(); // <- slower
    }

    static bool Filter(int number)
    {
        return number > 50;
    }
}