using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC48_Framework_Ind.Startup))]
namespace MVC48_Framework_Ind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
