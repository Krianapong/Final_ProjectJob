using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_ProjectJob.Startup))]
namespace Final_ProjectJob
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
