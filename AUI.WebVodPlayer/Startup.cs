using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AUI.WebVodPlayer.Startup))]
namespace AUI.WebVodPlayer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
