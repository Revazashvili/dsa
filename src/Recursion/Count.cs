/// <summary>
/// Calculates passed array count using recursion
/// </summary>
internal static class Count
{
    internal static int Run(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        return 1 + Run(arr[1..]);
    }
}