using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ej2_mvc_grid_copypaste.Startup))]
namespace ej2_mvc_grid_copypaste
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
