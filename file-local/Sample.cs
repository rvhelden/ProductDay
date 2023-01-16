public partial class Sample
{
    private record PrivateScopedData();

    private void Method()
    {
        var fileScopedData = new FileScopedData(2);
    }
}

file record FileScopedData(int Id);