using Tyuiu.Kucherenkonm.Sprint4.Task4.V23.Lib;
namespace Tyuiu.Kucherenkonm.Sprint4.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 8, 7, 5, 8, 7 }, { 8, 3, 3, 6, 4 }, { 4, 4, 5, 5, 4 }, { 3, 4, 7, 7, 3 }, { 6, 8, 3, 6, 7 } };
            int res = ds.Calculate(matrix);
            int wait = 65;
            Assert.AreEqual(wait, res);
        }
    }
}
