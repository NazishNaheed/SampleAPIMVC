using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleAPIMVC.Startup))]
namespace SampleAPIMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
