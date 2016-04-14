using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HnadyMan.Startup))]
namespace HnadyMan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
