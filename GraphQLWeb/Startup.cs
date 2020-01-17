using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQLWeb.GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQLWeb
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
            // need to add this for .net core 3
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
            services.AddControllers();
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<CarvedRockSchema>();
            services.AddGraphQL(o => { o.ExposeExceptions = true; }).AddGraphTypes(ServiceLifetime.Scoped);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {      
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseGraphQL<CarvedRockSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}