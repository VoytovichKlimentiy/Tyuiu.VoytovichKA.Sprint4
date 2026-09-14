using Tyuiu.VoytovichKA.Sprint4.Task1.V29.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds=new DataService();
            int[] arr = { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            int res = ds.Calculate(arr);
            Assert.AreEqual(res, 31);
        }
    }
}
