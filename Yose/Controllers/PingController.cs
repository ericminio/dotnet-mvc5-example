using System.Web.Mvc;
using Yose.PingChallenge;

namespace Yose.Controllers
{
    public class PingController : Controller
    {
		public ICanAnswerPingRequest Ping = new Ping();

        public ActionResult Index()
        {
			return Json(Ping.Response(), JsonRequestBehavior.AllowGet);
        }
    }
}