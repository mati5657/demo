using System.Web.Mvc;

namespace demo_v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }

        [Route("returns")]
        public ActionResult Returns()
        {
            return View();
        }

        [Route("shoppings")]
        public ActionResult Shoppings()
        {
            return View();
        }

        [Route("shop-rules")]
        public ActionResult ShopRules()
        {
            return View();
        }
    }
}