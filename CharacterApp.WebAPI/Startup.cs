using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CharacterApp.WebAPI.Startup))]

namespace CharacterApp.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
