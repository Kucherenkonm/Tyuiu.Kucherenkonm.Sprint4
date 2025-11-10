using Tyuiu.Kucherenkonm.Sprint4.Task3.V16.Lib;
namespace Tyuiu.Kucherenkonm.Sprint4.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas = { { 5, 8, 5, 8, 4 }, { 2, 3, 4, 6, 3 }, { 1, 1, 2, 9, 9 }, { 6, 7, 4, 1, 2 }, { 5, 7, 1, 8, 7 } };
            int res = ds.Calculate(mas);
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
