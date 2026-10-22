using Tyuiu.GrigorenkoMR.Sprint3.Task0.V8.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int startK = 1;
            int stopK = 10;
            var res = ds.GetMultiplySeries(a, startK, stopK);
            Assert.AreEqual(0.019, res);
        }
    }
}
