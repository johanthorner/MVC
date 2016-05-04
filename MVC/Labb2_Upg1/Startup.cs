using System;
using Labb2_Upg1.Models;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb2_Upg1.Startup))]
namespace Labb2_Upg1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            Random rnd = new Random();
            int startNumber = rnd.Next(0, 2);
            numberModel.num = startNumber;
        }
    }
}
