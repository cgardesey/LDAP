using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LDAP.Startup))]
namespace LDAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
