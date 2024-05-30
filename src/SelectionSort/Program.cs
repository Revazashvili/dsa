using Extensions;

int[] arr = [3, 2, 10, 4, 11];
Console.WriteLine("Before:");
ArrayExtensions.Print(arr);

var result = SelectionSort.Run(arr);

Console.WriteLine("After:");
ArrayExtensions.Print(result);

/// <summary>
/// Selection sort algorithm finds smallest element to passed array, removes it and appends to another sorted array
/// </summary>
internal static class SelectionSort
{
    internal static int[] Run(int[] arr)
    {
        var length = arr.Length;
        var result = new int[length];
        
        for (var i = 0; i < length; i++)
        {
            var smallest = ArrayExtensions.FindSmallest(arr);
            
            result[i] = smallest.Element;
            
            ArrayExtensions.RemoveAt(ref arr, smallest.Index);
        }

        return result;
    }
}