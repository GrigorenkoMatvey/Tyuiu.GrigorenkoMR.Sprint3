using Tyuiu.GrigorenkoMR.Sprint3.Task6.V3.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 19;
            var res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(121, res);
        }
    }
}