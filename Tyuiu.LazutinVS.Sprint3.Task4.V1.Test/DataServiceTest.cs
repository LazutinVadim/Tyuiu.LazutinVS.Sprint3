using Tyuiu.LazutinVS.Sprint3.Task4.V1.Lib;
namespace Tyuiu.LazutinVS.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double expected = 0.7677; // предварительно посчитанная сумма от -5 до -1
            double actual = ds.Calculate(-5, 5);


            // округляем до 4 знаков после запятой
            Assert.AreEqual(Math.Round(expected, 4), Math.Round(actual, 4));
        }
    }
}
