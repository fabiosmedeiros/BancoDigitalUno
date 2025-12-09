using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BancoDigitalUno.Web.Startup))]
namespace BancoDigitalUno.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
