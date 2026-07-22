using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HelpDesk.Application.Interfaces;
using HelpDesk.Infrastructure.Persistence;
using HelpDesk.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace HelpDesk.Infrastructure.DependencyInjection
{
    public static  class InfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection")??
                throw new InvalidOperationException("Connection string not found.");

            services.AddDbContext<HelpDeskDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<HelpDeskDbContext>());

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;

                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<HelpDeskDbContext>()
            .AddDefaultTokenProviders();

            return services;
        }
    }
}
