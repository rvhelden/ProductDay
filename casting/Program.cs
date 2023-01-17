object value = 5;

if (value is int intValue)
{
    Console.WriteLine(intValue);
}

if (value is >= 5)
{
    Console.WriteLine("Value is larger or equal to 5");
}

if (value is > 1 and < 6)
{
    Console.WriteLine("Value is between 1 and 6");
}

value = 10;
if (value is > 1 and < 6 or 10)
{
    Console.WriteLine("Value is between 1 and 6 or 10");
}

