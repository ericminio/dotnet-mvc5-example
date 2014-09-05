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
            controller.Worker = Substitute.For<ICanAnswerPingRequest> ();
            controller.Index();

            controller.Worker.Received().Response();
        }

        [Test]
        public void ReturnsJson()
        {
            controller.Worker = Substitute.For<ICanAnswerPingRequest> ();;
            controller.Worker.Response().Returns(new AliveResponse());

            Assert.That(controller.Index(), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void UsesThePingImplementationInProduction()
        {
            Assert.That (controller.Worker, Is.InstanceOf<Pong> ());
        }
    }
}