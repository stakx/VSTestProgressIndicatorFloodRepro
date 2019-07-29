using System.Threading;
using NUnit.Framework;

[TestFixture]
public class Tests
{
    [Test]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    [TestCase(5)]
    [TestCase(6)]
    [TestCase(7)]
    [TestCase(8)]
    [TestCase(9)]
    public void Test(int i)
    {
        Thread.Sleep(1000);
    }
}
