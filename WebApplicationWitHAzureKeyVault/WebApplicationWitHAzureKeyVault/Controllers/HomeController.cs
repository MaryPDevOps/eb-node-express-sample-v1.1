using System.Web.Mvc;

namespace WebApplicationWitHAzureKeyVault.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
