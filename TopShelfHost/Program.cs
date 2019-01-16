using System;

namespace TopShelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost();

            serviceHost.Run();
            
            Console.Read();
        }
    }
}
