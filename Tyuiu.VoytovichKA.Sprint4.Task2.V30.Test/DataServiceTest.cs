using Tyuiu.VoytovichKA.Sprint4.Task2.V30.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[] arr = { 2, 3, 5, 6, 7, 4, 5, 6, 3, 4, 5, 6 };
            int res = ds.Calculate(arr);
            Assert.AreEqual(res,7875);
        }
    }
}
