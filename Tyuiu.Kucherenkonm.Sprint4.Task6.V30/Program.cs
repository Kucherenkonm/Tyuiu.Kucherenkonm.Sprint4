using Tyuiu.Kucherenkonm.Sprint4.Task6.V30.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*         Вывести элементы массива, длина которых больше 5                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        var trees = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
        Console.WriteLine("Исходный массив: ");
        for (int i=0;i<= trees.Length - 1; i++)
        {
            Console.WriteLine(trees[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Элементы, длина которых больше пяти: ");
        string[] res = ds.Calculate(trees);

        Console.WriteLine(string.Join(", ", res));
        Console.ReadKey();
    }
}