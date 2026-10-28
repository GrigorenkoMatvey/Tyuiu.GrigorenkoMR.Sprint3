using Tyuiu.GrigorenkoMR.Sprint3.Task3.V21.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string strTest = "f3g5ht g4j 34kg4";
            string wait = "fegeht gej eekge";

            var res = ds.ReplaceNumOnChar(strTest, 'e');

            Assert.AreEqual(wait, res);
        }
    }
}