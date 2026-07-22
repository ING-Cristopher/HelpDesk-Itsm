using System;
using System.Collections.Generic;
using System.Text;
using HelpDesk.Application.Interfaces;
using HelpDesk.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Infrastructure.Persistence
{
    /// <summary>
    /// Contexto principal de la aplicacion.
    /// Centraliza cceso a identity y futuras entidades de negocio.
    /// </summary>
    public sealed class HelpDeskDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>, IApplicationDbContext
    {
        public HelpDeskDbContext(DbContextOptions<HelpDeskDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Configuraciones de EF Core se registraran automaticamente
            //conforme el rpoyecto crezca y se agreguen nuevas entidades.
            builder.ApplyConfigurationsFromAssembly(typeof(HelpDeskDbContext).Assembly);
        }
    }
}
