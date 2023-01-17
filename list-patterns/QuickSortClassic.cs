namespace list_patterns;

public static class QuickSortClassic
{
    public static IEnumerable<T> QuickSort<T>(IEnumerable<T> values) where T : IComparable
    {
        if (values == null || !values.Any())
        {
            return new List<T>();
        }

        //split the list into the first element and the rest
        var firstElement = values.First();
        var rest = values.Skip(1);

        //get the smaller and larger elements
        var smallerElements = QuickSort(rest.Where(i => i.CompareTo(firstElement) < 0));
        var largerElements = QuickSort(rest.Where(i => i.CompareTo(firstElement) >= 0));

        //return the result
        return smallerElements
            .Concat(new List<T> { firstElement })
            .Concat(largerElements);
    }
}
