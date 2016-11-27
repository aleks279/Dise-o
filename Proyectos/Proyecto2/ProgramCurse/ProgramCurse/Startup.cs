using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgramCurse.Startup))]
namespace ProgramCurse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
