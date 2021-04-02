using CrossCuting.IoC.Extensions;
using CrossCuting.IOC.Extensions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;
using Application.Mappers;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace Gym
{
    public class Startup
    {
        private const string policyCorsGym = "policyCorsGym";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            

            var mappingConfig = new MapperConfiguration(mc => 
            {
                mc.AddMaps(new[] {
                    typeof(CustomerMapper),
                    typeof(ClassMapper)
                });
                
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gym API", Version = "v1" });
            });

            var connectionString = Configuration.GetSection("ConnectionString").Value;
            services.AddRepository(connectionString, "Infra.Data.Migrations")
                .AddServices()
                .AddDomainServices()
                .AddCustomHttp()
                .AddHttpClient()
                .AddMediatR(typeof(Startup));

            services.AddCors(options =>
            {
                options.AddPolicy(name: policyCorsGym,
                    builder =>
                    {
                        builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                    });
            });

            services.AddControllers().AddNewtonsoftJson(o => o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseCors(policyCorsGym);
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gym API V1");
            });

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
