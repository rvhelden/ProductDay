
if (Method("hoi"))
{
    Console.WriteLine("It is hoi");
}

if (Method("cloud"))
{
    Console.WriteLine("It is cloud");
}

bool Method(ReadOnlySpan<char> text)
{
    return text is "hoi";
}