using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppWithAuthentication.Startup))]
namespace MVCAppWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
