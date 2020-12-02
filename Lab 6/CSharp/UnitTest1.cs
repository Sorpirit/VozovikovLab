using NUnit.Framework;

namespace CSharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(64, Haha());
        }

        private int Haha(int preveNum = 2,int n = 1)
        {
            if (n >= 5)
                return preveNum * 2;

            return Haha(preveNum * 2, n + 1);
        }
    }
}