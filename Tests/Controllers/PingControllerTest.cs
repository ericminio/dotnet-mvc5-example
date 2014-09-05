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
        PingController decorator;

        [SetUp]
        public void ThisDecorator()
        {
            decorator = new PingController();
        }

        [Test]
        public void DecoratesAWorkerThatCanAnswerAPingRequest()
        {
            decorator.Worker = Substitute.For<ICanAnswerPingRequest> ();
            decorator.Index();

            decorator.Worker.Received().Response();
        }

        [Test]
        public void ReturnsJson()
        {
            decorator.Worker = Substitute.For<ICanAnswerPingRequest> ();;
            decorator.Worker.Response().Returns(new AliveResponse());

            Assert.That(decorator.Index(), Is.InstanceOf<JsonResult>());
        }

        [Test]
        public void UsesThePongImplementationInProduction()
        {
            Assert.That (decorator.Worker, Is.InstanceOf<Pong> ());
        }

        [Test]
        public void DecoratesThePongServiceInOrderToBeUsedInsideAnMvcApplication()
        {
            Assert.That (decorator, Is.InstanceOf<Controller> ());
        }
    }
}