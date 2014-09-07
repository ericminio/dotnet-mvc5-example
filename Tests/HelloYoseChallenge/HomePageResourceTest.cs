using System;
using NUnit.Framework;
using Yose;

namespace Tests
{
    [TestFixture]
    public class HomePageResourceTest
    {
        [Test]
        public void ThisResourceIsEmbedded ()
        {
            var assembly = typeof(HomeController).Assembly;
            var names = assembly.GetManifestResourceNames ();

            Assert.That (names[0], Is.EqualTo("Yose.HelloYoseChallenge.home.html"));
        }
    }
}