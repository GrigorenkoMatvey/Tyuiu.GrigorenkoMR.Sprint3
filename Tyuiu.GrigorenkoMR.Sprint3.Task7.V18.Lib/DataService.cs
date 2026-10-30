using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorenkoMR.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; // создаем массив с указанной длиной

            double f;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double d = Math.Cos(x) + x;

                if (d == 0)
                {
                    f = 0;
                }
                else
                {
                    f = Math.Round(((2 * x - 3) / d) + 5, 2); 
                }

                valueArray[count] = f; // присваиваем значение в массив с индексом count
                count++;
            }

            return valueArray;
        }
    }
}