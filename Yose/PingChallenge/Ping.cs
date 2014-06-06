using System;

namespace Yose.PingChallenge
{
	public class Ping : ICanAnswerPingRequest
	{
		public object Response ()
		{
			return new AliveResponse { alive = true };
		}
	}
}