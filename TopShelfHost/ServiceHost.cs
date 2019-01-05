using Topshelf;

namespace TopShelfHost
{
    public class ServiceHost
    {
        public void Run()
        {
            var host = HostFactory.New(x =>
            {
                x.Service<Service>(s =>
                {
                    s.ConstructUsing(v => new Service());
                    s.WhenStarted(w => w.Start());
                    s.WhenStopped(w => w.Stop());
                });

                x.RunAsLocalService();

                x.SetDescription("Service description");
                x.SetDisplayName("Display name");
                x.SetServiceName("Service name");
            });

            var topshelfExitCode = host.Run();


        }
    }
}
