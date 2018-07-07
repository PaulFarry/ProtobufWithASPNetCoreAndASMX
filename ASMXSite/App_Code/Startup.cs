using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASMXWebSite.Startup))]
namespace ASMXWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // ConfigureAuth(app);
        }
    }
}
