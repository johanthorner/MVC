using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb4_Upg2_v2.Startup))]
namespace Labb4_Upg2_v2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
