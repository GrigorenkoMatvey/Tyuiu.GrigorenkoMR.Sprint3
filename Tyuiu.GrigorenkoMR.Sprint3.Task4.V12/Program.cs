using Tyuiu.GrigorenkoMR.Sprint3.Task4.V12.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task4.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и breake в циклах               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке [-5; 5] вычислить значение функции y = x/(x + sin(x)) + 2.5. *");
            Console.WriteLine("* При x = 0 прервать цикл. Полученные значения перемножать.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue, stopValue;
            Console.WriteLine(" Введите начало отрезка:");
            startValue = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine(" Введите конец отрезка:");
            stopValue = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(startValue, stopValue));
            Console.ReadLine();
        }
    }
}