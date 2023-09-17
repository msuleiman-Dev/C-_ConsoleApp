using System.Text;
using NUnit.Framework;
namespace ArrayUtil.Tests;
[TestFixture]
public class ApplicationTest
{
    StringBuilder _consoleOutputValues;

    [SetUp]
    public void SetUp()
    {
        _consoleOutputValues = new StringBuilder();
        var consoleAppoutputWriter = new StringWriter(_consoleOutputValues);
        Console.SetOut(consoleAppoutputWriter);
    }

    [Test]
    public void ApplicationOutPutTest()
    {
        Program.Main(default);
        var result = _consoleOutputValues.ToString().Split("\n");
        Assert.That(result[0], Is.EqualTo("X:13"));
        Assert.That(result[1], Is.EqualTo("Array:1,3,5,8,10"));
        Assert.That(result[2], Is.EqualTo("Output:2"));
    }
}
