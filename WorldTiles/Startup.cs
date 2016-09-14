using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorldTiles.Startup))]
namespace WorldTiles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
