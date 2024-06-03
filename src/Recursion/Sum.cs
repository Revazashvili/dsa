/// <summary>
/// Calculates sum of passed array using recursion
/// </summary>
internal static class Sum
{
    internal static int Run(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        return arr[0] + Run(arr[1..]);
    }
}