using NUnit.Framework;

namespace ArrayUtil.Tests;
[TestFixture]
public class GetTotalSumTest
{
    int[] _arrayToTest;
    int _targetTestSum;
    [SetUp]
    public void Setup()
    {
        _arrayToTest = new int[] { 1, 3, 5, 8, 10 };
        _targetTestSum = 13;
    }

    [Test]
    public void GetTotalSumValueTest()
    {
        var result = Iterator.GetTotalNumberOfSums(_targetTestSum, _arrayToTest);
        Assert.That(result, Is.EqualTo(2));
       
    }
}