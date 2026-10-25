using Tyuiu.GrigorenkoMR.Sprint3.Task2.V11.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double x = 0.5;
            int startValue = 1;
            int stopValue = 15;

            var res = ds.GetSumSeries(x, startValue, stopValue);

            Assert.AreEqual(0.430, res);
        }
    }
}