
namespace SportShop.SportStore.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportStore/Order"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrderRow))]
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportStore/Order/OrderIndex.cshtml");
        }
    }
}