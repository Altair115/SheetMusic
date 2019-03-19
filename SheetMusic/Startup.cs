using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SheetMusic.Startup))]
namespace SheetMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
