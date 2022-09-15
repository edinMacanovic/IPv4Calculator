using IPv4Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IPv4CalculatorTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public static void TestCalculateNetzId()
    {
        var result = CalculateMethods.CalculateNetzId("192.168.15.12", "255.255.248.0");
        Assert.AreEqual("192.168.15.0", result);
    }
    [TestMethod]
    public static void TestCalculateBroadCast()
    {
        var result = CalculateMethods.CalculateBroadCast("192.168.15.12", "255.255.248.0");
        Assert.AreEqual("192.168.15.255", result);
    }
    [TestMethod]
    public static void TestCalculateFirstHost()
    {
        var result = CalculateMethods.CalculateFirstHost("192.168.15.12", "255.255.248.0");
        Assert.AreEqual("192.168.8.1", result);
    }
    [TestMethod]
    public static void CaculateLastHost()
    {
        var result = CalculateMethods.CaculateLastHost("192.168.15.12", "255.255.248.0");
        Assert.AreEqual("192.168.15.254", result);
    }
    [TestMethod]
    public static void CalculateMaximumHost()
    {
        var result = CalculateMethods.CalculateMaximumHost( "255.255.248.0");
        Assert.AreEqual("2046", result);
    }
}