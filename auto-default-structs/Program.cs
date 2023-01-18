var value = new IntValue(5);

internal struct IntValue
{
    public int Number;

    public IntValue()
    {
    }

    public IntValue(int number)
    {
        this.Number = number;
    }
}
