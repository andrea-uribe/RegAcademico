using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegAcademico.Startup))]
namespace RegAcademico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
