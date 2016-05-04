using Labb2_upg2.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb2_upg2.Startup))]
namespace Labb2_upg2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
            ConfigureAuth(app);
        }
    }
}
