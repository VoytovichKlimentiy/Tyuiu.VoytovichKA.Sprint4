using Tyuiu.VoytovichKA.Sprint4.Task7.V26.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 3, b = 2;
            string str = "162491";
            DataService ds = new DataService();
            int res = ds.Calculate(a,b,str);
            Assert.AreEqual(48,res);
        }
    }
}
