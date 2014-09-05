using System;
using NUnit.Framework;
using Yose.PingChallenge;
using System.Reflection;

namespace Tests
{
    [TestFixture]
    public class AliveResponseTest
    {
        static FieldInfo[] fields;

        [SetUp]
        public void TheAliveResponse()
        {
            fields = new AliveResponse ().GetType ().GetFields ();
        }

        [Test]
        public void HasASingleFieldAsExpectedByYoseTheGame()
        {
            Assert.That (fields.Length, Is.EqualTo (1));
        }

        [TestFixture]
        public class ThisField
        {
            FieldInfo field = fields [0];

            [Test]
            public void HasTheNameExpectedByYoseTheGame()
            {
                Assert.That (field.Name, Is.EqualTo("alive"));
            }

            [Test]
            public void IsABoolean()
            {
                Assert.That (field.FieldType, Is.EqualTo (typeof(bool)));
            }

            [Test]
            public void IsReadonly()
            {
                Assert.That (field.IsInitOnly, Is.True);
            }

            [Test]
            public void IsTrue()
            {
                Assert.That (field.GetValue (new AliveResponse ()), Is.True);
            }
        }
    }
}

