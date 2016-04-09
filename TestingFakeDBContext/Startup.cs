using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingFakeDBContext.Startup))]
namespace TestingFakeDBContext
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
