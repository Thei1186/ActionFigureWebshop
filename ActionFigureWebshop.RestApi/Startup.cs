using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionFigureWebshop.Core.ApplicationServices;
using ActionFigureWebshop.Core.ApplicationServices.Services;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Infrastructure.SQL;
using ActionFigureWebshop.Infrastructure.SQL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ActionFigureWebshop.RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddScoped<IActionFigureService, ActionFigureService>();
            services.AddScoped<IActionFigureRepository, ActionFigureRepository>();

            if (Environment.IsDevelopment())
            {
                services.AddDbContext<ActionFigureShopContext>(
                    opt => opt.UseSqlite("Data Source=ActionFigureShop.db")
                );
            }
            else
            {
                services.AddDbContext<ActionFigureShopContext>(
                    opt => opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ActionFigureShopContext>();
                    context.Database.EnsureDeleted();
                    DbInitializer.SeedDB(context);
                }
                app.UseDeveloperExceptionPage();
            }
            else
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ActionFigureShopContext>();
                    context.Database.EnsureCreated();
                }
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
