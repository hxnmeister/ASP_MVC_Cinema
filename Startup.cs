using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC_Cinema
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "/", new { controller = "Cinema", action = "Index" });
                routes.MapRoute("movies", "/movies", new { controller = "Cinema", action = "Index" });
                routes.MapRoute("sessions", "/sessions/{id}", new { controller = "Cinema", action = "GetSessions" });
            });
        }
    }
}
