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

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\n�i���� �i��i�����!");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Lab4_1.Program.Hrystyna.Rating = 80;

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\n����� ������� �����!");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Lab4_1.Program.Hrystyna.Rating = 60;

            Assert.AreEqual(Lab4_1.Program.Hrystyna.StudentRating(), "\n����� �i���� ����� ����i���� ��������!");
        }
    }
}

