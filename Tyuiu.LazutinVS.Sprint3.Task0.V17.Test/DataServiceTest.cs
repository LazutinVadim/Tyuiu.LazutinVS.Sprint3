using Tyuiu.LazutinVS.Sprint3.Task0.V17.Lib;

namespace Tyuiu.LazutinVS.Sprint3.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(value, startValue, stopValue);

            // Правильный расчет ожидаемого значения
            double wait = 0.0;
            for (int i = startValue; i < stopValue; i++)
            {
                wait += Math.Cos(i) * 0.5;
            }

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}
