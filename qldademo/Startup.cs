using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(qldademo.Startup))]
namespace qldademo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
