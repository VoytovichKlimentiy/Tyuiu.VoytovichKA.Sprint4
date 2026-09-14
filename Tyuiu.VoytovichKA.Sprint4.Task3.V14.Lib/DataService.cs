using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VoytovichKA.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int res = array[0, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 3] > res) res = array[i, 3];
            }
            return res;
        }
    }
}
