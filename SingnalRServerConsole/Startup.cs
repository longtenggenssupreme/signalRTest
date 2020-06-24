using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SingnalRServer.Startup))]
namespace SingnalRServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HubConfiguration
            {
                EnableDetailedErrors = true
            };
            //设置可以跨域访问
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            //映射到默认的管理
            app.MapSignalR(config);
        }
    }
}
