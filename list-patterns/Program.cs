using list_patterns;

var numbers = new[] { 100, 12, 15, 65, 99, 160 };

if (numbers is [100, 12])
{
    Console.WriteLine("numbers is [100, 12]");
}

if (numbers is [100, 12, ..])
{
    Console.WriteLine("numbers is [100, 12, ..]");
}

if (numbers is [>= 99 and <= 101, 12, .. var tail])
{
    Console.WriteLine($"These are the other numbers {string.Join(", ", tail)}");
}

var sorted1 = QuickSortClassic.QuickSort(numbers);
Console.WriteLine($"Classic way sorted numbers {string.Join(", ", sorted1)}");

var sorted2 = QuickSortModern.QuickSort(numbers);
Console.WriteLine($"Modern way sorted numbers {string.Join(", ", sorted2)}");
