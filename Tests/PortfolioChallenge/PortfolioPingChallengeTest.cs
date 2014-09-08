using System;
using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
using Yose;
using System.Net.Http.Headers;
using System.Net;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

namespace Tests
{
    [TestFixture]
    public class PortfolioPingChallengeTest : WebTest
    {
        HttpResponseMessage response;

        [SetUp]
        public void TheHelloYoseChallenge() 
        {
            response = client.GetAsync ("http://localhost").Result;
        }

        [Test]
        public void DisplaysALinkTothePingChallengeImplementation ()
        {
            var content = ((StringContent)response.Content).ReadAsStringAsync ().Result;

            var html = new HtmlDocument();
            html.LoadHtml (content);
            var document = html.DocumentNode;
            var element = document.QuerySelector ("a#ping-challenge-link");

            Assert.That (element, Is.Not.Null); 
            Assert.That (element.Attributes ["href"].Value, Is.EqualTo ("ping"));
            Assert.That (element.InnerText, Is.EqualTo ("The ping challenge"));
        }
    }
}