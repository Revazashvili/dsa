/// <summary>
/// Binary Search algorithm takes sorted array and one item, for every iteration it splits array in two halves
/// to find passed element index. if item in the middle if less than passed, keeps searching in second half,
/// otherwise in first part.
/// 
/// algorithm returns index of passed item in the array, if not exists -1.
/// </summary>
internal static class BinarySearch
{
    internal static int Run(int[] array, int item)
    {
        // maximum index to search after in array
        var max = array.Length;
        
        // each time we're splitting array in two halves
        var middle = max / 2;

        // take element from middle
        var guess = array[middle];
        
        // if we found passed element return index
        if (guess == item)
            return middle;

        // if we did not found item and array contains 1 element, there is nothing to search in
        if (guess != item && max == 1)
            return -1;

        // if item in the middle is less than passed, we should search in the second part of array, after middle index
        if (guess < item)
            return Run(array[middle..], item);

        // if item in the middle is more than passed, we should search in the first part of array, before middle index
        return Run(array[..middle], item); // guess > item
    }
}