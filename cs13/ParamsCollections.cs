public class ParamsCollections{
    public static void PrintNumbers(params List<int> numbers){
        foreach(var number in numbers){
            Console.Write(number+" ");
        }
        Console.WriteLine();
    }
}