// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace ArrayUtil;
internal class Program
{
    internal static void Main(string[] args)
    {
        var targetArray = new[] { 1, 3, 5, 8, 10 };
        var targetSum = 13;
        var totalSumsFound = Iterator.GetTotalNumberOfSums(targetSum, targetArray);
        Console.WriteLine($"X:{targetSum}");
        var arrayString = string.Join(",", targetArray);
        Console.WriteLine($"Array:{arrayString}");
        Console.WriteLine($"Output:{totalSumsFound}");
    }
}
