using System.Web.Mvc;

namespace Yose.Controllers
{
    public class PingController : Controller
    {
        public ActionResult Index()
        {
            return Json(new { alive = true }, JsonRequestBehavior.AllowGet);
        }
    }
}

