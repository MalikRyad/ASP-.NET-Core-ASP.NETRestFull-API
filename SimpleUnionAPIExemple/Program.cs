using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleUnionAPIExemple
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            var webHost = CreateHostBuilder(args).Build();

         //   ApplyMigrations(webHost.Services);

            webHost.Run();
        }


        private static void  ApplyMigrations(IServiceProvider serviceProvider)
        {
             using var scope = serviceProvider.CreateScope();

              using RepositoryDbContext dbContext = scope.ServiceProvider.GetRequiredService<RepositoryDbContext>();

             dbContext.Database.Migrate();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
