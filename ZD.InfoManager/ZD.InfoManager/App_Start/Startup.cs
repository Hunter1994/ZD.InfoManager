using Abp.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using ZD.InfoManager.WebApi.Controllers;

[assembly: OwinStartup(typeof(ZD.InfoManager.Startup))]
namespace ZD.InfoManager
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseAbp();

            app.UseOAuthBearerAuthentication(AccountController.OAuthBearerOptions);

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.MapSignalR();
        }
    }
}
