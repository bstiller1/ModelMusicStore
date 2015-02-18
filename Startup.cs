using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModelMusicStore.Startup))]
namespace ModelMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
