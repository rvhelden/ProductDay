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
            case [var first, .. var other]:
                var smaller = QuickSort(other.Where(x => x.CompareTo(first) < 0).ToArray());
                var larger = QuickSort(other.Where(x => x.CompareTo(first) >= 0).ToArray());
                return smaller.Append(first).Concat(larger).ToArray();
        }

        throw new UnreachableException();
    }
}
