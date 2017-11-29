using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZD.InfoManager.Startup))]
namespace ZD.InfoManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
