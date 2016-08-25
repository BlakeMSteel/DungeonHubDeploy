using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DungeonHubHelloWorld.Startup))]
namespace DungeonHubHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
