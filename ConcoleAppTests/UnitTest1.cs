using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using ConcoleApp;
using Microsoft.VisualBasic;
using Nunit.Framework;

namespace ConcoleAppTests;

public class UnitTest1
{
    StringBuilder _consoleAppoutput;
    [SetUp]
    public void Setup()
    {
        _consoleAppoutput = new StringBuilder();
        var consoleAppoutputWriter = new StringWriter(_consoleAppoutput);
        Console.SetOut(consoleAppoutputWriter);

    }
    [Test]
    public void TestMethod1()
    {
        Program.Main(default);
       var result = _consoleAppoutput.ToString().Split("`r`n");
        Assert.AreEqual("10",result[0]);
        Assert.AreEqual("1,3,5,8,10",result[1]);
        Assert.AreEqual("1",result[2]);
    }
}