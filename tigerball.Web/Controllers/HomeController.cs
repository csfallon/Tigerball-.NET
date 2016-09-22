using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace tigerball.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : tigerballControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}