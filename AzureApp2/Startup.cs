using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureApp2.Startup))]
namespace AzureApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
