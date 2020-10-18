using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Steeltoe.Management.Endpoint;

namespace ProfileService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)          
                .ConfigureWebHostDefaults(webBuilder =>
                {                   
                    webBuilder.UseStartup<Startup>();                
                })            
                .AddHealthActuator()
                .AddInfoActuator()
                .AddLoggersActuator();
    }
}
