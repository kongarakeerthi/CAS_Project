using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CAS_Project.Startup))]
namespace CAS_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
