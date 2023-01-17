var sample = new Sample();

internal struct Sample
{
    public int Number1;
    public int Number2;

    public Sample()
    {
        this.Number1 = 0;
        this.Number2 = 0;
    }

    public Sample(int number1, int number2)
    {
        this.Number1 = number1;
        this.Number2 = number2;
    }
}
