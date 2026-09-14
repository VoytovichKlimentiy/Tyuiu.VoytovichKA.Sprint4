using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Tyuiu.VoytovichKA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task5.V13
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 4 до 8. Заменить отрицательные     *");
            Console.WriteLine("* элементы на 0.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.Write("* Введите количество строк в массиве: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите количество столбцов в массиве: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[col, row];

            Random rnd = new Random();
            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= col - 1; j++)
                {
                    arr[i, j] = rnd.Next(-2, 5);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ",\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(arr);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + ",\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}