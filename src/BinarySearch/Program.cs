
int[] arr = [1, 3, 5, 7, 9];
Console.WriteLine($"Position: {Algorithm.BinarySearch(arr, 3)}");
Console.WriteLine($"Position: {Algorithm.BinarySearch(arr, 2)}");

public static class Algorithm
{
    /// <summary>
    /// Binary Search algorithm takes sorted array and one item, for every iteration it splits array in two halves
    /// to find passed element index. if item in the middle if less than passed, keeps searching in second half,
    /// otherwise in first part.
    /// 
    /// algorithm returns index of passed item in the array, if not exists -1.
    /// </summary>
    public static int BinarySearch(int[] array, int item)
    {
        // minimum index to search after in array
        var min = 0;

        // maximum index to search after in array
        var max = array.Length;

        // we are searching until min is less than or equal to max,
        // that's point where min becomes max, last index of array or max index to search before
        while (min <= max)
        {
            // each time we're splitting array in two halves
            var middle = (min + max) / 2;

            // take element from middle
            var guess = array[middle];

            // if we found passed element return index
            if (guess == item)
                return middle;

            // if item in the middle is less than passed, we should search in the second part of array, after middle index
            if (guess < item)
                min = middle + 1;

            // if item in the middle is more than passed, we should search in the first part of array, before middle index
            if (guess > item)
                max = middle - 1;
        }

        // if we didn't find passed element, return -1
        return -1;
    }
}