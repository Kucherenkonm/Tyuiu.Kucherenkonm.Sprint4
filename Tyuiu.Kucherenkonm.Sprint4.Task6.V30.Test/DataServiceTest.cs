using Tyuiu.Kucherenkonm.Sprint4.Task6.V30.Lib;
namespace Tyuiu.Kucherenkonm.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VallidCalculate()
        {
            DataService ds = new DataService();
            var trees = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            var res = ds.Calculate(trees);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
