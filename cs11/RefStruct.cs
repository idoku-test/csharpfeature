
// public class RefStruct{
    
//     public static Span<int> CreateSpan(ref int v)
// {
//       return new Span<int>(v);
// }

//         public static Span<int> Foo(int value)
// {
//        return CreateSpan(ref value);
// }
// }

public readonly ref struct Span<T>
{
    private readonly ref T _field;
    private readonly int _length;
    public Span(ref T value)
    {
        _field = ref value;
        _length = 1;
    }
}