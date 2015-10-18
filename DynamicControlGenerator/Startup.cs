using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicControlGenerator.Startup))]
namespace DynamicControlGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
