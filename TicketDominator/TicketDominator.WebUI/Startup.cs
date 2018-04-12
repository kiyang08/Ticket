using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketDominator.WebUI.Startup))]
namespace TicketDominator.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
