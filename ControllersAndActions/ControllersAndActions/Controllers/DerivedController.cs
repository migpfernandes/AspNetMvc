using ControllersAndActions.Infrastructure;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        //
        // GET: /Derived/

        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
        }

        public ActionResult ProductOutput()
        {
            return Redirect( "/Basic/Index" );
        }
    }
}
