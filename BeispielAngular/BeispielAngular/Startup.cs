using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeispielAngular.Startup))]
namespace BeispielAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
