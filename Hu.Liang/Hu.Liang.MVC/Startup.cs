using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hu.Liang.MVC.Startup))]
namespace Hu.Liang.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
