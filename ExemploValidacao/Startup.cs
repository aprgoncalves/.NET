using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploValidacao.Startup))]
namespace ExemploValidacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
