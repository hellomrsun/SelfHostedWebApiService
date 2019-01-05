using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace TopShelfHost
{
    public class UnityResolver : IDependencyResolver
    {
        private readonly IUnityContainer _unityContainer;

        public UnityResolver(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _unityContainer.Resolve(serviceType);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _unityContainer.ResolveAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            var child = _unityContainer.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            _unityContainer.Dispose();
        }
    }
}
