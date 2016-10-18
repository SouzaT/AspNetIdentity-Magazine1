using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityMagazine.Startup))]
namespace IdentityMagazine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
