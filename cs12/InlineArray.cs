[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;
}


public class InlineArray{

public static void Print(){
        var buffer = new Buffer();
        for (int i = 0; i < 10; i++)
        {
            buffer[i] = i;
        }

        foreach (var i in buffer)
        {
            Console.Write(i + " ");
        }
         Console.WriteLine();
    }
}

