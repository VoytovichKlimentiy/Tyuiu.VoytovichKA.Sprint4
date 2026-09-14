using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VoytovichKA.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            int res = array.Count(i => i.Length < 7);
            return res;
        }
    }
}
