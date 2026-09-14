using Tyuiu.VoytovichKA.Sprint4.Task6.V27.Lib;

namespace Tyuiu.VoytovichKA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            string[] arr = { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            DataService ds = new DataService();
            int res = ds.Calculate(arr);
            Assert.AreEqual(1, res);
        }
    }
}
