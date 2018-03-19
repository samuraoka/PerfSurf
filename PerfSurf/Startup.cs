using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PerfSurf.Startup))]

namespace PerfSurf
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Microsoft ASP.NET SignalR
            // https://www.nuget.org/packages/Microsoft.AspNet.SignalR/
            // Install-Package -Id Microsoft.AspNet.SignalR -ProjectName PerfSurf
            app.MapSignalR();

            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
