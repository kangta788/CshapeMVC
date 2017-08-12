using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CH01.Startup))]
namespace CH01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
