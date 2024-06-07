using Extensions;

int[] arr = [1, 54, 2, 78, 9, 4, -3];
Console.WriteLine("Sort array using quicksort algorithm");
Console.Write("Before sort: ");
EnumerableExtensions.Print(arr);

Console.Write("After sort: ");
EnumerableExtensions.Print(Quicksort.Run(arr));

/// <summary>
/// Quicksort algorithm use Divide & Conquer (D&C). base case is array with 0 or 1 elements which don't need to be sorted
/// recursive case is pivot, used to take sub array greater and less than pivot and sort them is each iteration.
/// </summary>
internal static class Quicksort
{
    internal static int[] Run(int[] arr)
    {
        if (arr.Length < 2)
            return arr;

        // if you take first element as pivot this would be worst case, you have to go through entire array. O(n^2)
        // if you take middle one this would be faster, you divide array in two halves every time. O(n log n)
        var pivot = arr[arr.Length / 2];

        var greater = (from i in arr where i > pivot select i).ToArray();
        var less = (from i in arr where i < pivot select i).ToArray();

        return Run(less).Concat([pivot]).Concat(Run(greater)).ToArray();
    }
}