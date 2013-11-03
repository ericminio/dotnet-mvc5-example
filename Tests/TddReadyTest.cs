using NUnit.Framework;

namespace Tests
{
    [TestFixture()]
    public class TddReadyTest
    {
        [Test()]
        public void TestEnvironment()
        {
            Assert.That(1 + 1, Is.EqualTo(2));
        }
    }
}

