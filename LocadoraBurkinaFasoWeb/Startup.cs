using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocadoraBurkinaFasoWeb.Startup))]
namespace LocadoraBurkinaFasoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
