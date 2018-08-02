using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EJ2_MVC_Grid_Copy_Paste.Startup))]
namespace EJ2_MVC_Grid_Copy_Paste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
