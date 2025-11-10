using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Kucherenkonm.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int res = 10;
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                if (array[i, rows - 1] < res)
                {
                    res = array[i, rows - 1];
                }
            }
            return res;
        }
    }
}
