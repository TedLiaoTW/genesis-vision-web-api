using Ipfs;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;

namespace GV.WebApi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
               .UseContentRoot(Directory.GetCurrentDirectory())
               .UseKestrel()
               .UseStartup<Startup>()
               .Build();

            host.Run();
        }
    }
}