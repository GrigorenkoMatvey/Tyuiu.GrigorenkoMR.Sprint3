using Tyuiu.GrigorenkoMR.Sprint3.Task7.V18.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вывести таблицу значений функции на отрезке [-5; 5] с шагом 1.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            // Получаею длину массива
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            
            // Заполняею массив значениями
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            // Создаею локальную переменную для вывода
            int currentX = startValue;

            for (int i = 0; i < len; i++)
            {
                // Вывожу текущий X (выравнивание по правому краю 6 знаков)
                // и значение f(x) (выравнивание по правому краю 6 знаков с 2 знаками после запятой)
                Console.WriteLine("| {0,6}   | {1,6:F2}   |", currentX, valueArray[i]);

                currentX++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}