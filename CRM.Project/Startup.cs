using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM.Project.Startup))]
namespace CRM.Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
