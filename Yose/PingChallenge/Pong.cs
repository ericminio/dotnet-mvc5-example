namespace Yose.PingChallenge
{
    public class Pong : ICanAnswerPingRequest
    {
        public AliveResponse Response ()
        {
            return new AliveResponse();
        }
    }
}