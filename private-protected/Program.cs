public class Source
{
    protected private virtual int Value => 4;

    public void Print()
    {
        Console.WriteLine(this.Value);
    }
}

public class InheritedSource : Source
{
    protected override private int Value => 5;
}