using Tyuiu.VoytovichKA.Sprint4.Task0.V24.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[] arr = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res=ds.GetMultEvenArrEl(arr);
            Assert.AreEqual(res, 32);
        }
    }
}
