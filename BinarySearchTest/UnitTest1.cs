namespace BinarySearchTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethodm1()
    {
        Assert.AreEqual(-1, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2, 3 }, 5));
    }
    [TestMethod]
    public void TestMethod4()
    {
        Assert.AreEqual(-1, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2, 3, 5 }, 4));
    }
    [TestMethod]
    public void TestMethodm4()
    {
        Assert.AreEqual(-1, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2, 3 }, -4));
    }
    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreEqual(2, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2, 3 }, 2));
    }
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(1, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2 }, 1));
    }
    [TestMethod]
    public void TestMethods1()
    {
        Assert.AreEqual(1, Kate.Search.BinarySearch.Search(new List<int> { 0, 1, 2, 3, 4 }, 1));
    }
    [TestMethod]
    public void TestMethod0()
    {
        Assert.AreEqual(-1, Kate.Search.BinarySearch.Search(new List<int> { }, 2));
    }
}