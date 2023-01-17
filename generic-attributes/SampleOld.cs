public class SampleOld
{
    [OneOf(typeof(string))]
    //[OneOf(typeof(string), typeof(int))]
    public void Method()
    {

    }
}

[AttributeUsage(AttributeTargets.Method)]
file class OneOfAttribute : Attribute
{

    public OneOfAttribute(params Type[] types)
    {
        this.Types = types;
    }
    public Type[] Types { get; }
}
