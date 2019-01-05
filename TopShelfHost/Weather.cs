using System.Web.Http;
using IocInitializer;
using Owin;
using Unity.WebApi;
using WeatherApi;

namespace TopShelfHost
{
    public class Weather
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(config.Formatters.JsonFormatter);

            var unityContainer = new Initializer().Get();

            config.DependencyResolver = new UnityDependencyResolver(unityContainer);

            SwaggerConfig.Register(config);

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}
