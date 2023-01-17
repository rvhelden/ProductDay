var value = new Values();
Demo.Method(ref value);


static class Demo
{    
    public static void Method(ref Values value)
    {
        ReadOnlySpan<int> values = stackalloc int[5] { 1, 2, 3, 4, 5 };

        //value.Set(values);
        var sum = value.Sum(values);

        Console.WriteLine(sum);
    }
}




public ref struct Values
{
    public ReadOnlySpan<int> Value;
    
    public void Set(ReadOnlySpan<int> value)
    {
        this.Value = value;
    }
    
    public int Sum(scoped ReadOnlySpan<int> value)
    {
        int sum = 0;
        
        foreach (var number in value)
        {
            sum += number;
        }
        
        return sum;
    }
}
