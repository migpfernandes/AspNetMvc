using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        //
        // GET: /Example/

        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;

            return View();
        }

        public RedirectResult Redirect()
        {
            return Redirect("/Example/Index");
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToRoute(new
            {
                controller = "Example",
                action = "Index",
                ID = "MyID"
            });
        }

        public HttpStatusCodeResult StatusCode()
        {
            return HttpNotFound();
        }
    }
}
