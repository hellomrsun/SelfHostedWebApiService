using System.Linq;
using System.Web.Http;
using Unity;
using Unity.RegistrationByConvention;
using WeatherApi.Controller;

namespace IocInitializer
{
    public class Initializer
    {
        private readonly IUnityContainer _unityContainer;

        public Initializer()
        {
            _unityContainer = new UnityContainer();

            var controllers = typeof(HeartbeatController)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(ApiController)) && !t.IsAbstract)
                .Select(t => t);

            _unityContainer.RegisterTypes(controllers);
        }

        public IUnityContainer Get()
        {
            return _unityContainer;
        }
    }
}
