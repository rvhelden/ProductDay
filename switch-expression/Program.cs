Print(new Item(1, "action"));
Print(new Item(2, "action"));
Print(new Item(3, "sample"));
Print(new Item(-1, "sample"));
Print(new Item(0, "sample"));

void Print(Item value)
{
    var returnValue = value switch
    {
        { Value1: 1, Value2: "action" } => "Is 1 & action",
        { Value2: "action" } => "Is action",
        { Value1: > 0 } => "Is more than 0",
        { Value1: < 0, Value2: var extra } => $"Is less than 0 and captured value {extra}",
        _ => "Doesn't match",
    };
    
    Console.WriteLine(returnValue);
}

record Item(int Value1, string? Value2);