// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("ArrayUtil.Tests")]
namespace ArrayUtil;
internal class Program
{
    internal static void Main(string[] args)
    {
        var targetArray = new[] { 1, 3, 5, 8, 10 };
        var targetSum = 13;
        var totalSumsFound = Iterator.GetTotalNumberOfSums(targetSum, targetArray);
        Console.WriteLine($"X{0}", targetSum);
        Console.WriteLine($"Array:{0}", targetArray.ToString());
        Console.WriteLine($"Output:{0}", totalSumsFound);
    }
}
