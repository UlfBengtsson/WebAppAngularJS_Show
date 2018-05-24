using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAngularJS_Show.Startup))]
namespace WebAppAngularJS_Show
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
