using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(az532Demo.Startup))]
namespace az532Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
