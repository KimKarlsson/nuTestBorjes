using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nuTestBorje.Startup))]
namespace nuTestBorje
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
