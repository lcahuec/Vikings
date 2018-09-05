using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vikings.Startup))]
namespace Vikings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
