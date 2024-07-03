public class NumericIntPtr{
    public static void Method(){
        
        nint x = 3;
        int y = 3;
        long v = 10;

        nint.Equals(x, y); // False
        nint.Equals(x, (nint)y); // True

        var test1 = y + 1 > x; // True;
        var test2 = y - 1 == x; // False

        var test3 = typeof(nint); // System.IntPtr
        var test4 = typeof(nuint); // System.UIntPtr
        var test5 = (x + 1).GetType(); // System.IntPtr
        var test6 = (x + y).GetType(); // System.IntPtr
        var test7 = (x + v).GetType(); // System.Int64
        Console.WriteLine(test3);
        Console.WriteLine(test4);
    }
}