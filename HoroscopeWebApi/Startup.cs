using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoroscopeWebApi.Startup))]
namespace HoroscopeWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
