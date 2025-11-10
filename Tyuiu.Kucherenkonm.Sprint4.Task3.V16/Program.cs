using Tyuiu.Kucherenkonm.Sprint4.Task3.V16.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        int[,] mas = { { 5, 8, 5, 8, 4 }, { 2, 3, 4, 6, 3 }, { 1, 1, 2, 9, 9 }, { 6, 7, 4, 1, 2 }, { 5, 7, 1, 8, 7 } };
        int rows = mas.GetUpperBound(0) + 1;
        int colums = mas.Length / rows;
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*        Найти минимальный элемент в последнем столбце массива            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{mas[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Минимальный элемент: ");
        int res = ds.Calculate(mas);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}