using FrontDesk.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace FrontDesk.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var resolver = ObjectFactory.GetInstance<IDependencyResolver>();
            //var config = new HubConfiguration { Resolver = resolver };
            app.MapSignalR();
        }
    }
}