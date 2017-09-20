using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGMaps.Startup))]
namespace RPGMaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
