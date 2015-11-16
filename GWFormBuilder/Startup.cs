using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GWFormBuilder.Startup))]
namespace GWFormBuilder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
