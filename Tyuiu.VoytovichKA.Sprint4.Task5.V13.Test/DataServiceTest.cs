using Tyuiu.VoytovichKA.Sprint4.Task5.V13.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[,] arr = { { 2, -2, 4 }, { 5, 3, -1 }, { 0, 4, -2 } };
            int[,] res = ds.Calculate(arr);
            int[,] check = { { 2, 0, 4 }, { 5, 3, 0 }, { 0, 4, 0 } };
            CollectionAssert.AreEqual(res,check);
        }
    }
}
