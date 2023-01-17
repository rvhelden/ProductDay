Console.WriteLine();

[My(nameof(arg1))]
void Method(int arg1)
{

}

internal class MyAttribute : Attribute
{
    public MyAttribute(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }
}
