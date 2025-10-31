using Tyuiu.LazutinVS.Sprint3.Task6.V15.Lib;
namespace Tyuiu.LazutinVS.Sprint3.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var varForTest = 168;
            Assert.AreEqual(varForTest, ds.GetSumTheDivisors(6, 15));
        }
    }
}
