using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace SalesManagementSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SalesManagementSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}