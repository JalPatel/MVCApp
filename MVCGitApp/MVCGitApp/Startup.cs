using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGitApp.Startup))]
namespace MVCGitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
