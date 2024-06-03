/// <summary>
/// Find max element in array using recursion
/// </summary>
internal static class Maximum
{
    internal static int Run(int[] arr)
    {
        if (arr.Length == 0)
            return 0;

        var max = arr[0];
        var target = Run(arr[1..]);

        return max > target ? max : target;
    }
}