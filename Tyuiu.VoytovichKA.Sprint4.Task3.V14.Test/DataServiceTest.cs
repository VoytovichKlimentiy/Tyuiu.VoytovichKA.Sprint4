using Tyuiu.VoytovichKA.Sprint4.Task3.V14.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int[,] arr = { 
                { 3, 2, 3, 3, 5 }, 
                { 2, 3, 3, 7, 3 }, 
                { 7, 5, 2, 7, 3 }, 
                { 4, 2, 7, 5, 2 }, 
                { 3, 5, 4, 2, 6 } 
            };
            int res = ds.Calculate(arr);
            Assert.AreEqual(7,res);
        }
    }
}
