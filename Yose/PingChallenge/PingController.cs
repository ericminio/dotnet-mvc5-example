using System.Web.Http;
using System.Net.Http;
using System.Net;
using Yose.PingChallenge;
using System.Net.Http.Formatting;

namespace Yose.Controllers
{
    public class PingController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new AliveResponse(), Configuration.Formatters.JsonFormatter);
        }
    }
}