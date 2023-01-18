namespace generic_attributes;

public static class Utility
{
    public static void Print(Type type, string method)
    {
        var methodInfo = type.GetMethod(method);

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
    }
}
