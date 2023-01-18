namespace utf_8_string_literals;

public class Utility
{
    public static void Print(ReadOnlySpan<byte> text)
    {
        Console.WriteLine(string.Join(" ", text.ToArray().Select(x => $"0x{x}")));
    }
}
