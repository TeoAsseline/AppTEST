namespace AppTEST.Client.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EgaliteINT()
        {
            Assert.Equals(1+2, 3);
        }
        [TestMethod]
        public void InegaliteINT()
        {
            Assert.AreNotEqual(2, 3);
        }
    }
}