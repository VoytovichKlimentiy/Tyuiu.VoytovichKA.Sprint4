using System.ComponentModel.DataAnnotations;
using System.Numerics;
using Tyuiu.VoytovichKA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Войтович К.А. | НТм-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Войтович Климентий Антонович | НТм-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". Преобразуйте её     ");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение чётных чисел.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string str = "351268459614723";
            int a = 5, b = 3, index = 0;
            int[,] arr = new int[a, b];
            Console.WriteLine("Массив: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
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
            Console.WriteLine(ds.Calculate(a, b, str));
            Console.ReadLine();
        }
    }
}