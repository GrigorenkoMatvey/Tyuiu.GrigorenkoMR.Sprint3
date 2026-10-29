using Tyuiu.GrigorenkoMR.Sprint3.Task4.V12.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(467.590, res);
        }
    }
}