public class TimerRemaining
{
    public int[] buffer = new int[10];
}

public class ImplicitIndexerAccess
{
    public static void IndexerAccess()
    {
        var countdown = new TimerRemaining
        {
            buffer =
            {
                [^1] = 0,
                [^2] = 1,
                [^3] = 2,
                [^4] = 3,
                [^5] = 4,
                [^6] = 5,
                [^7] = 6,
                [^8] = 7,
                [^9] = 8,
                [^10] = 9
            }
        };
        foreach (var value in countdown.buffer)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}