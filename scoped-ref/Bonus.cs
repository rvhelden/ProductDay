namespace scoped_ref
{
    public class Bonus
    {
        public unsafe void Method(ref Values value)
        {
            ReadOnlySpan<int> values = stackalloc int[5] { 1, 2, 3, 4, 5 };
            int[] test = new int[] { 1, 2, 3, 4, 5 };

            var stackAddress = &test;
        }
    }
}
