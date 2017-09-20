using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGMaps.Web.Startup))]
namespace RPGMaps.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
