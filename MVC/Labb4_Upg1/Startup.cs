using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb4_Upg1.Startup))]
namespace Labb4_Upg1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
