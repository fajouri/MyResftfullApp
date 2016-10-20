namespace MyRestfulApi.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "REST FUL API";

            return View();
        }
    }
}
