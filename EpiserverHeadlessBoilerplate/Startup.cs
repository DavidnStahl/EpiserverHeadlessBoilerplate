using EPiServer.Cms.UI.AspNetIdentity;
using EpiserverHeadlessBoilerplate.Business;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Web;

namespace EpiserverHeadlessBoilerplate
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.AddCmsAspNetIdentity<ApplicationUser>();

            app.UseAdministratorRegistrationPage(() => HttpContext.Current.Request.IsLocal);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString(Global.LoginPath),
                Provider = new CookieAuthenticationProvider
                {
                    OnApplyRedirect = cookieApplyRedirectContext =>
                    {
                        app.CmsOnCookieApplyRedirect(cookieApplyRedirectContext, cookieApplyRedirectContext.OwinContext.Get<ApplicationSignInManager<ApplicationUser>>());
                    },

                    OnValidateIdentity = SecurityStampValidator.OnValidateIdentity<ApplicationUserManager<ApplicationUser>, ApplicationUser>(
                        validateInterval: TimeSpan.FromMinutes(30),
                        regenerateIdentity: (manager, user) => manager.GenerateUserIdentityAsync(user))
                }
            });
        }
    }
}