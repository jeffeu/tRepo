using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deployTeste.Startup))]
namespace deployTeste
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
