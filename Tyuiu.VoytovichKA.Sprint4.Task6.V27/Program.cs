using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Tyuiu.VoytovichKA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Многомерные массивы (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Квадрат\", \"Прямоугольник\", \"Круг\",        *");
            Console.WriteLine("* \"Треугольник\", \"Пятиугольник\", \"Шестиугольник\", \"Восьмиугольник\"].      *");
            Console.WriteLine("* Используя класс Array, подсчитайте количество элементов, длина которых  *");
            Console.WriteLine("* меньше 7.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string[] arr = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}