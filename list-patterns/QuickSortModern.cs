namespace list_patterns;

using System.Diagnostics;

public static class QuickSortModern
{
    public static T[] QuickSort<T>(T[] values)
        where T : IComparable
    {
        switch (values)
        {
            case []:
                return Array.Empty<T>();
            case [var pivot, .. var other]:
                var smaller = QuickSort(other.Where(x => x.CompareTo(pivot) < 0).ToArray());
                var larger = QuickSort(other.Where(x => x.CompareTo(pivot) >= 0).ToArray());
                return smaller.Append(pivot).Concat(larger).ToArray();
        }

        throw new UnreachableException();
    }
}
