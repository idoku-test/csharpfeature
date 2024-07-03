public class PatternMatchSpan
{
    public static void Method()
    {
        ReadOnlySpan<char> province = "QC".AsSpan(); // Or Span<char>

        var DoWeSpeakFrenchHere = province switch
        {
            "QC" => true,
            "NB" => true,
            _ => false
        }; // Return True
        Console.WriteLine("DoWeSpeakFrenchHere:" + DoWeSpeakFrenchHere);
        var DoWeSpeakFrenchAgainHere = province is "ON"; // Return False
        Console.WriteLine("DoWeSpeakFrenchAgainHere:" + DoWeSpeakFrenchAgainHere);
    }
}