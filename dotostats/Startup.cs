using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotostats.Startup))]
namespace dotostats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
