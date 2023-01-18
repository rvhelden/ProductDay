var point = new Point(1, 2);

var (x, y) = point;



public readonly struct Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = this.X;
        y = this.Y;
    }
}





public static class Extensions
{
    /*public static void Deconstruct(this Point point, out int x, out int y)
    {
        x = point.X;
        y = point.Y;
    }*/
}