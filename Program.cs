using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Chores.Entities;
using Chores.BLL;

namespace Chores
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*
            ChoreBLL bll = new ChoreBLL();
            for (int x = 0; x < 100000; x++)
            {
                bll.Create(new Chore() { Name = "test" + x });
            }
            */

            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();

            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
