public class SampleNew
{
    [OneOf<string>]
    [OneOf<string, int>]
    public void Method()
    {

    }
}

[AttributeUsage(AttributeTargets.Method)]
file class OneOfAttribute<T1> : Attribute
{
}

[AttributeUsage(AttributeTargets.Method)]
file class OneOfAttribute<T1, T2> : Attribute
{
}
