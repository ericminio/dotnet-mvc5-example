using NUnit.Framework;
using Yose.PingChallenge;

namespace Tests.PingChallenge
{
	[TestFixture]
	public class PingTest
	{
		private Pong ping;

		[SetUp]
		public void ThisRoute()
		{
			ping = new Pong ();
		}

		[Test]
		public void ReturnsAnAliveResponse ()
		{
			Assert.That (ping.Response(), Is.InstanceOf<AliveResponse> ());
		}

		[Test]
		public void ReturnsTheExpectedAliveResponse()
		{
			var response = (AliveResponse)ping.Response();

			Assert.That (response.alive);
		}
	}
}