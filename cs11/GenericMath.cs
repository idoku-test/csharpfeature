public class GenericMath{
    public static void UnsignedRightShiftOpt(){
        int x = -8;
        Console.WriteLine($"Before:    {x,11}, hex: {x,8:x}, binary: {Convert.ToString(x, toBase: 2), 32}");
        int y = x >> 2;
        Console.WriteLine($"After  >>: {y,11}, hex: {y,8:x}, binary: {Convert.ToString(y, toBase: 2), 32}");
        int z = x >>> 2;
        Console.WriteLine($"After >>> 2: {z,11}, hex: {z,8:x}, binary: {Convert.ToString(z, toBase: 2).PadLeft(32, '0'), 32}");
        int n = x >>> 5;
        Console.WriteLine($"After >>> 5: {n,11}, hex: {n,8:x}, binary: {Convert.ToString(n, toBase: 2).PadLeft(32, '0'), 32}");
    }
    
}

public record struct Point(int X, int Y)
{
    public static Point operator checked +(Point left, Point right)
    {
        checked
        {
            return new Point(left.X + right.X, left.Y + right.Y);
        }
    }
    
    public static Point operator +(Point left, Point right)
    {
        return new Point(left.X + right.X, left.Y + right.Y);
    }
}