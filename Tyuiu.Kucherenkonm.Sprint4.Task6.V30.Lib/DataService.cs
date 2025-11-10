using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Kucherenkonm.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            List<string> result = new List<string>();

            foreach (string trees in array)
            {
                if (trees.Length > 5)
                {
                    result.Add(trees);
                }
            }

            return result.ToArray();
        }
    }
}
