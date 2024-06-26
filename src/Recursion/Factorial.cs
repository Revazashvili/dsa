/// <summary>
/// Calculates passed number's factorial using recursion
/// </summary>
internal static class Factorial
{
    internal static int Run(int number)
    {
        if (number == 1)
            return 1;
        
        return number * Run(number - 1);
    }
    
    internal static int UsingLinqAggregate(int number)
    {
        return number == 1 ? 1 : Enumerable.Range(1, number).Aggregate((first, second) => first * second);
    }
}