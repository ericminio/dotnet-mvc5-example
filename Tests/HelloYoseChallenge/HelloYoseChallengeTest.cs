using System;
using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
using Yose;
using System.Net.Http.Headers;
using System.Net;

namespace Tests
{
    [TestFixture]
    public class HelloYoseChallengeTest
    {
        HttpResponseMessage response;

        [SetUp]
        public void TheHelloYoseChallenge() 
        {
            var config = new HttpConfiguration();                       
            MvcApplication.RegisterRoutes (config);
            var server = new HttpServer(config);

            var client = new HttpClient(server);

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

        [Test]
        public void ReturnsTheExpectedGreeting()
        {
            Assert.That (((StringContent)response.Content).ReadAsStringAsync().Result, Is.StringContaining ("Hello Yose")); 
        }
    }
}

