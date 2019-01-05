using System;
using TopShelfHost;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoster = new ServiceHost();

            hoster.Run();


            Console.Read();
        }
    }
}
