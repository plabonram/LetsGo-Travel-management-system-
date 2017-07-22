using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetsGo.Startup))]
namespace LetsGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
