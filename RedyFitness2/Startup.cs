using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedyFitness2.Startup))]
namespace RedyFitness2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
