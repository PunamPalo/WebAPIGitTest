using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamlePPMVC.Startup))]
namespace SamlePPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
