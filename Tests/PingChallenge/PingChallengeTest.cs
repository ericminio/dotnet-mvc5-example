using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
using System.Net;
using Yose;
using Yose.PingChallenge;
using System.Net.Http.Headers;

namespace Tests
{
    [TestFixture]
    public class PingChallengeTest : WebTest
    {
        HttpResponseMessage response;

        [SetUp]
        public void ThePingChallenge() 
        {
            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/xml"));
            response = client.GetAsync ("http://localhost/ping").Result;
        }

        [Test]
        public void IsOnline()
        {
            Assert.That (response.StatusCode, Is.EqualTo (HttpStatusCode.OK));
        }      

        [Test]
        public void ReturnsJsonEvenIfXmlWasAsked()
        {
            Assert.That (response.Content.Headers.ContentType.MediaType, Is.EqualTo ("application/json"));
        }

        [Test]
        public void ReturnsTheAliveResponse()
        {
            Assert.That (((ObjectContent)response.Content).Value, Is.InstanceOf<AliveResponse>());
        }
    }
}