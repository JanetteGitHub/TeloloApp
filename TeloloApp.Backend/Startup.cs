using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeloloApp.Backend.Startup))]
namespace TeloloApp.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
