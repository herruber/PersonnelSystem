using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectPersonelSystem.Startup))]
namespace ProjectPersonelSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
