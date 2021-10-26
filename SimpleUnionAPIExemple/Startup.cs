using Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Service.Abstractions;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistance.Repositories;
using Persistance;
using Microsoft.EntityFrameworkCore;

namespace SimpleUnionAPIExemple
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IRepositoryManager, RepositoryManager>();


             services.AddScoped<ICommandService, CommandService>();

            //   services.AddScoped<ICommandRepo, CommandRepo>();


            services.AddDbContext<RepositoryDbContext>(opt =>
                    opt.UseInMemoryDatabase("MultiserviceDataBase"));


            //    services.AddDbContext<RepositoryDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), mig => mig.MigrationsAssembly("Persistance")));

            //  opt.UseInMemoryDatabase("InMen"));

            // services.AddDB

            //services.AddDbContext<RepositoryDbContext>(builder =>
            //{
            //    var connectionString = Configuration.GetConnectionString("Database");

            //    builder.

            //}
            //);
            //services.AddScoped<ICommandService,CommandService>();

            //services.AddScoped<ICommandRepo, CommandRepo>();

            //   services.AddDbContext<RepositoryDbContext>(opt => opt.UseInMemoryDatabase("InMen"));

            // service.AddDb

            //services.AddDbContextPool<RepositoryDbContext>(builder =>
            //{
            //    var connectionString = Configuration.GetConnectionString("Database");

            //    builder.UseNpgsql(connectionString);
            //});


             services.AddControllers();

          //  var assembly = System.Reflection.Assembly.Load("Presentation");

            //   services.AddMvc().AddApplicationPart(assembly).AddControllersAsServices();

            //services.AddControllers()
            //    .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SimpleUnionAPIExemple", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SimpleUnionAPIExemple v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
