public class RawString
{
    public static void Method()
    {
        string lm = """
This is a long message.
    It has several lines.
        Some are indented
                more than others.
    Some should start at the first column.
    Some have "quoted text" in them.
""";
  Console.WriteLine(lm);
    }

    public static void location(double Longitude, double Latitude)
    {      
        var location = $$"""
   You are at {{{Longitude}}, {{Latitude}}}
   """;
        Console.WriteLine(location);
    }
}