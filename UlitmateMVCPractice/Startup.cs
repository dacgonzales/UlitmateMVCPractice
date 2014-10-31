using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UlitmateMVCPractice.Startup))]
namespace UlitmateMVCPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
