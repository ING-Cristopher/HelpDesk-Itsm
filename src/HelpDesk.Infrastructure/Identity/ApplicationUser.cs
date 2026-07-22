using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HelpDesk.Infrastructure.Identity
{
    /// <summary>
    /// Usuario principal de la aplicacion.
    /// Extiende AspNetCore.Identity para incorporar informacion de negocio.
    /// </summary>
    public sealed class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set;  } = string .Empty;

        public string LastName { get; set; } = string .Empty;

        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Fecha de creacion almacenada en UTC.
        /// </summary>
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    }
}
