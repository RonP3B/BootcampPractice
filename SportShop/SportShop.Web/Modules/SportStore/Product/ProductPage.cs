
namespace SportShop.SportStore.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportStore/Product"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductRow))]
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportStore/Product/ProductIndex.cshtml");
        }
    }
}