using NUnit.Framework;

namespace Tests
{
    public class ArticleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.Fail();
        }

        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
    }
}