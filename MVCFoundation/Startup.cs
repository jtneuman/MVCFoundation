using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFoundation.Startup))]
namespace MVCFoundation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
