using generic_attributes;

Utility.Print(typeof(Car), nameof(Car.Start));

internal class Car
{
    [IgnitionMethod(typeof(Keyless), typeof(Key))]
    public void Start()
    {
        
    }
}

[AttributeUsage(AttributeTargets.Method)]
class IgnitionMethodAttribute : Attribute
{
    public Type[] Types { get; }

    public IgnitionMethodAttribute(params Type[] types)
    {
        this.Types = types;
    }
}
