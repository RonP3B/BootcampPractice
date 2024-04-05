
namespace SportShop.SportStore.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportStore/Customer"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CustomerRow))]
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportStore/Customer/CustomerIndex.cshtml");
        }
    }
}