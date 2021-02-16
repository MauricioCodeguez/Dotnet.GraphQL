using Dotnet.GraphQL.Api.GraphQL;
using Dotnet.GraphQL.Api.GraphQL.Extensions.DependencyInjection;
using Dotnet.GraphQL.CrossCutting.Extensions.DependencyInjection;
using Dotnet.GraphQL.Domain.Abstractions.Extensions.DependencyInjection;
using Dotnet.GraphQL.Repositories.Abstractions.Entensions.DependencyInjection;
using Dotnet.GraphQL.Repositories.Extensions.DependencyInjection;
using Dotnet.GraphQL.Services.Abstractions.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Dotnet.GraphQL.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services
                .AddBuilders()
                .AddRepositories()
                .AddUnitOfWork()
                .AddAutoMapper()
                .AddApplicationServices()
                .AddMessageServices()
                .AddSubjects()
                .AddNotificationContext();

            services.AddApplicationDbContext(options =>
            {
                options.DefaultConnection = _configuration.GetConnectionString(nameof(options.DefaultConnection));
                _configuration.Bind(nameof(options.ConnectionResiliency), options.ConnectionResiliency);
            });

            services.AddApplicationGraphQL(options
                => options.IsDevelopment = _env.IsDevelopment());

            services.Configure<KestrelServerOptions>(options
                => options.AllowSynchronousIO = true);
        }

        public void Configure(IApplicationBuilder app)
        {
            if (_env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });

            app.UseApplicationGraphQL<ApplicationSchema>();
        }
    }
}
