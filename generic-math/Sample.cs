public class Sample : IAddition<Sample>
{
    public int Number { get; set; }

    public Sample(int number)
    {
        this.Number = number;
    }

    public static Sample operator +(Sample sample1, Sample sample2) => new Sample(sample1.Number + sample2.Number);
}

public class SampleFactory : IFactory<Sample>
{
    public static Sample CreateInstance()
    {
        return new Sample(0);
    }
}