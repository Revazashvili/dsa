
Console.WriteLine("Factorial of 5 (5 * 4 * 3 * 2 * 1 = 120)");
Console.WriteLine(Factorial.Run(5));

/// <summary>
/// Calculates passed number's factorial using recursion
/// </summary>
internal static class Factorial
{
    internal static int Run(int number)
    {
        if (number == 1)
            return 1;
        else
            return number * Run(number - 1);
    }
}