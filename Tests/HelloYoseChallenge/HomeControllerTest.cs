using System;
using NUnit.Framework;
using Yose;

namespace Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        HomeController controller;

        [SetUp]
        public void ThisController()
        {
            controller = new HomeController ();
        }

        [Test]
        public void CanGetHomePageContent ()
        {
            Assert.That (controller.GetHomePageContent (), Is.Not.Empty);
        }
    }
}

