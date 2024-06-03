/// <summary>
/// Find max element in array using recursion
/// </summary>
internal static class Maximum
{
    internal static int Run(int[] arr)
    {
        return arr.Length == 0 ? 0 : Math.Max(arr[0], Run(arr[1..]));
    }
}