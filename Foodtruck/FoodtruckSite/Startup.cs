using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodtruckSite.Startup))]
namespace FoodtruckSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
