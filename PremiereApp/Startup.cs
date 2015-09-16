using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PremiereApp.Startup))]
namespace PremiereApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
