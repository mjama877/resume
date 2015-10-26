using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCGameRankings.Startup))]
namespace PCGameRankings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
