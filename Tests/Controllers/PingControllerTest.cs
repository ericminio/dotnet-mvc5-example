using NUnit.Framework;
using System.Web.Mvc;
using Yose.Controllers;
using NSubstitute;
using Yose.PingChallenge;

namespace Tests
{
    [TestFixture]
    public class PingControllerTest
    {
        PingController controller;

        [SetUp]
        public void ThisController()
        {
            controller = new PingController();
        }

        [Test]
        public void AsksForHelpToSomeoneWoCanAnswerPing()
        {
            var mock = Substitute.For<ICanAnswerPingRequest> ();
            controller.Worker = mock;
            controller.Index();

            mock.Received().Response();
        }

        [Test]
        public void ReturnsJson()
        {
            var mock = Substitute.For<ICanAnswerPingRequest> ();
            mock.Response().Returns(new { any = "value" });
            controller.Worker = mock;

            Assert.That(controller.Index(), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void UsesThePingImplementation()
        {
            Assert.That (controller.Worker, Is.InstanceOf<Pong> ());
        }
    }
}