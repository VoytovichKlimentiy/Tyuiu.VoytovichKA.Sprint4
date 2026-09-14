using Tyuiu.VoytovichKA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] arr = { { 5, 6, 5, 6, 5 }, { 5, 5, 5, 8, 4 }};
            int res = ds.Calculate(arr);
            Assert.AreEqual(24,res);
        }
    }
}
