using Tyuiu.GrigorenkoMR.Sprint3.Task5.V9.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 1;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            var res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            Assert.AreEqual(5.790, res);
        }
    }
}