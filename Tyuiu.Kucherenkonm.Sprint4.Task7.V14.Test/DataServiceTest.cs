using Tyuiu.Kucherenkonm.Sprint4.Task7.V14.Lib;
namespace Tyuiu.Kucherenkonm.Sprint4.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "458712659137";
            int res = ds.Calculate(rows, columns, str);
            int wait = 38;
            Assert.AreEqual(wait, res);
        }
    }
}
