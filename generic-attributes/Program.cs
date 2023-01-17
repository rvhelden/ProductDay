var methodInfo = typeof(SampleNew).GetMethod(nameof(SampleNew.Method));

Console.WriteLine(methodInfo!.Name);
foreach (var attribute in methodInfo.GetCustomAttributes(false))
{
    Console.WriteLine();

    var attributeType = attribute.GetType();
    Console.WriteLine($"Attribute type: {attributeType.Name}");
    foreach (var typeArgument in attributeType.GenericTypeArguments)
    {
        Console.WriteLine($"Attribute type argument: {typeArgument.Name}");
    }
}
