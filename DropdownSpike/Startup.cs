using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropdownSpike.Startup))]
namespace DropdownSpike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
