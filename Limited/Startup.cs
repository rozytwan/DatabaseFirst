using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Limited.Startup))]
namespace Limited
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
