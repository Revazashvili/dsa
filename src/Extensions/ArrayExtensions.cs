namespace Extensions;

public static class ArrayExtensions
{
    /// <summary>
    /// Finds smallest element in array
    /// </summary>
    public static (int Element, int Index) FindSmallest(int[] arr)
    {
        var smallestIndex = 0;
        var smallest = arr[smallestIndex];
        
        for (var i = 0; i < arr.Length; i++)
        {
            var current = arr[i];
            if (current > smallest) 
                continue;
            
            smallestIndex = i;
            smallest = current;
        }

        return (smallest, smallestIndex);
    }
    
    /// <summary>
    /// Swaps elements in array
    /// </summary>
    public static void Swap(int[] arr, int firstElementIndex, int secondElementIndex)
    {
        /*
         same as this code
         
           var temp = arr[firstElementIndex];
           arr[firstElementIndex] = arr[secondElementIndex];
           arr[secondElementIndex] = temp;
         */
        
        (arr[firstElementIndex], arr[secondElementIndex]) = (arr[secondElementIndex], arr[firstElementIndex]);
    }
    
    /// <summary>
    /// Prints elements in array
    /// </summary>
    public static void Print(IEnumerable<int> arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
    
    /// <summary>
    /// Prints elements in array
    /// </summary>
    public static void RemoveAt(ref int[] arr, int index)
    {
        var length = arr.Length;
        for (var i = index + 1; i < length; i++)
        {
            arr[i - 1] = arr[i];
        }
        
        Array.Resize(ref arr, length - 1);
    }
}