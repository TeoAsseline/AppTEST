namespace AppTEST.Client.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Equals(1+2, 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Equals(2, 3);
        }
        public void TestMethod3()
        {
            Assert.Equals(true,true);
        }
    }
}