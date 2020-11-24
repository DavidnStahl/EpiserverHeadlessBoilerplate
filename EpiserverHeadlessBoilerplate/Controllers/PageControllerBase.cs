using EPiServer.Web.Mvc;
using EPiServer.Shell.Security;
using System.Web.Mvc;
using EpiserverHeadlessBoilerplate.Business;
using EpiserverHeadlessBoilerplate.Models.Pages;
using EpiserverHeadlessBoilerplate.Models.Dtos;

namespace EpiserverHeadlessBoilerplate.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {

        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        public ActionResult Logout()
        {
            UISignInManager.Service.SignOut();

            return RedirectToAction("Index");
        }
    }
}