using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieStoreV3.Startup))]
namespace MovieStoreV3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
