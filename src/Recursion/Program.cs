
Console.WriteLine("Factorial of 5 (5 * 4 * 3 * 2 * 1 = 120)");
Console.WriteLine(Factorial.Run(5));
Console.WriteLine(Factorial.UsingLinqAggregate(5));

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