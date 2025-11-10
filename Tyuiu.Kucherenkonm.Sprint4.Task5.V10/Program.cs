using Tyuiu.Kucherenkonm.Sprint4.Task5.V10.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*              Найти сумму положительных элементов матрицы                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите количество строк в массиве: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в массиве: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, columns];
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i, j] = rnd.Next(-4,7);
            }
        }
        Console.WriteLine("\nМассив: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма положительных элементов: ");
        int res = ds.Calculate(mtrx);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}