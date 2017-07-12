using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureApp1.Startup))]
namespace AzureApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
