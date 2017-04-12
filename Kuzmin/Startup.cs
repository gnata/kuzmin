using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kuzmin.Startup))]
namespace Kuzmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
