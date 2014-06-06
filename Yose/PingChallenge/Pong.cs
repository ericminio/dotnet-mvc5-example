namespace Yose.PingChallenge
{
	public class Pong : ICanAnswerPingRequest
	{
		public object Response ()
		{
			return new AliveResponse { alive = true };
		}
	}
}