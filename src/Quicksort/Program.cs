using Extensions;

int[] arr = [1, 54, 2, 78, 9, 4, -3];
Console.WriteLine("Sort array using quicksort algorithm");
Console.Write("Before sort: ");
ArrayExtensions.Print(arr);

Console.Write("After sort: ");
ArrayExtensions.Print(Quicksort.Run(arr));

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

        var pivot = arr[0];

        var greater = (from i in arr where i > pivot select i).ToArray();
        var less = (from i in arr where i < pivot select i).ToArray();

        return Run(less).Concat([pivot]).Concat(Run(greater)).ToArray();
    }
}