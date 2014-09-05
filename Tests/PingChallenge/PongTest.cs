using NUnit.Framework;
using Yose.PingChallenge;

namespace Tests.PingChallenge
{
    [TestFixture]
    public class PongTest
    {
        private Pong pong;

        [SetUp]
        public void ThisService()
        {
            pong = new Pong ();
        }

        [Test]
        public void CanAnswerPingRequest()
        {
            Assert.That (pong, Is.InstanceOf<ICanAnswerPingRequest>());
        }
    }
}