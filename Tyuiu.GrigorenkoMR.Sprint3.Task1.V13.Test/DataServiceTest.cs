using Tyuiu.GrigorenkoMR.Sprint3.Task1.V13.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double n = 1.2;
            int startValue = 1;
            int stopValue = 7;

            var res = ds.GetMultiplySeries(n, startValue, stopValue);

            Assert.AreEqual(164.845, res);
        }
    }
}
