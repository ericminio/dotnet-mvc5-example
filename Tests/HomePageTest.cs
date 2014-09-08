using System;
using NUnit.Framework;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;

namespace Tests
{
    [TestFixture]
    public class HomePageTest : WebTest
    {
        HttpResponseMessage response;

        [SetUp]
        public void TheHelloYoseChallenge() 
        {
            client.DefaultRequestHeaders.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/xml"));
            response = client.GetAsync ("http://localhost").Result;
        }

        [Test]
        public void IsOnline()
        {
            Assert.That (response.StatusCode, Is.EqualTo (HttpStatusCode.OK));
        } 

        [Test]
        public void ReturnsTextHtmlEvenIfXmlWasAsked()
        {
            Assert.That (response.Content.Headers.ContentType.MediaType, Is.EqualTo ("text/html"));
        }
    }
}