using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VoytovichKA.Sprint4.Task7.V26.Lib
{
    public class DataService : ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 1;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i*m+j, 1));
                    if (matrix[i, j] % 2 == 0)
                    {
                        res *= matrix[i, j];
                    }

                }
            }
            return res;
        }
    }
}
