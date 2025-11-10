using Tyuiu.Kucherenkonm.Sprint4.Task7.V14.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int rows = 3;
        int columns = 4;
        int[,] mtrx = new int[rows, columns];
        string str = "458712659137";

        Console.Title = "Спринт #4 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление итоговых решений по спринту                            *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*  Дана строка из одноразрядных цифр \"458712659137\". Преобразовать ее   *");
        Console.WriteLine("*              в матрицу 3*4 и найти сумму нечетных чисел                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(rows, columns, str);
        Console.WriteLine("Сумма нечетных элементов: " + res);
        Console.ReadKey();
    }
}