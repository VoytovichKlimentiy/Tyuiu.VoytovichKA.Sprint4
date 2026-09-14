using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.VoytovichKA.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            int res=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0) res += matrix[i, j];
                }
            }
            return res;
        }
    }
}
