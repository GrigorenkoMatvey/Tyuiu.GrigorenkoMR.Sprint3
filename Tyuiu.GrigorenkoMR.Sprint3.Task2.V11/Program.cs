using Tyuiu.GrigorenkoMR.Sprint3.Task2.V11.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do...while                                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл do...while, которая вычисляет        *");
            Console.WriteLine("* сумму ряда по формуле: S = Сумма( (1 / (3 + x^i))^i ), где i = 1..15,   *");
            Console.WriteLine("* при x = 0,5.                                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            Console.WriteLine(" Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(x, startValue, stopValue));
            Console.ReadLine();
        }
    }
}
