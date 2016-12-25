using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bootstrap.jQuery.Startup))]
namespace Bootstrap.jQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
