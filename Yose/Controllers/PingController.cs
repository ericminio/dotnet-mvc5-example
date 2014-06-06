using System.Web.Mvc;
using Yose.PingChallenge;

namespace Yose.Controllers
{
    public class PingController : Controller
    {
        public ICanAnswerPingRequest Worker = new Pong();

        public ActionResult Index()
        {
            return Json(Worker.Response(), JsonRequestBehavior.AllowGet);
        }
    }
}