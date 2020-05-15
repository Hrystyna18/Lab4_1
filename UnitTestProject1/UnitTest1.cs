using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTestProject1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lab4_1.Program.Hrystyna.Rating = 95;

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\nВiтаємо вiдмiнника!");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Lab4_1.Program.Hrystyna.Rating = 80;

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\nМожна вчитися краще!");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Lab4_1.Program.Hrystyna.Rating = 60;

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\nВарто бiльше уваги придiляти навчанню!");
        }
    }
}

