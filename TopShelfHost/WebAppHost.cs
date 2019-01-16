using System;
using Microsoft.Owin.Hosting;

namespace TopShelfHost
{
    public class WebAppHost
    {
        private IDisposable _app;

        public void Start()
        {
            _app = WebApp.Start<WeatherService>("http://localhost:1234");
        }

        public void Stop()
        {
            _app.Dispose();
        }

    }
}
