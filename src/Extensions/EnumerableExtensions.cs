namespace Extensions;

public static class EnumerableExtensions
{
    /// <summary>
    /// Prints elements in array
    /// </summary>
    public static void Print(IEnumerable<int> arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}