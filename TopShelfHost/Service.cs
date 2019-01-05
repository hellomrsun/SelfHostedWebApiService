using System;
using Microsoft.Owin.Hosting;
using WeatherApi;

namespace TopShelfHost
{
    public class Service
    {
        private IDisposable app;

        public void Start()
        {
            app = WebApp.Start<Weather>("http://localhost:1234");
        }

        public void Stop()
        {
            app.Dispose();
        }

    }
}
