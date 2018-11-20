using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSample.Startup))]
namespace GitSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
