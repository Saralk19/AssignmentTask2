using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EducationForAll.Startup))]
namespace EducationForAll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
