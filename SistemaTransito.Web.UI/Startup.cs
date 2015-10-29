using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaTransito.Web.UI.Startup))]
namespace SistemaTransito.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
