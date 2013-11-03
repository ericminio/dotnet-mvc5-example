using NUnit.Framework;
using System.Web.Mvc;
using Yose.Controllers;

namespace Tests
{
    [TestFixture()]
    public class PingControllerTest
    {
        [Test()]
        public void ReturnsJson()
        {
            Assert.That(new PingController().Index(), Is.InstanceOf<JsonResult>());
        }

        [Test()]
        public void ReturnsTheValueExpectedByTheGame()
        {
            var expected = new JsonResult { Data = new { alive = true } }.Data;
            var actual = ((JsonResult)new PingController().Index()).Data;
            
            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
    }
}

