using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HelpDesk.Infrastructure.Identity
{
    /// <summary>
    /// Representa un rol de usuario en la aplicación.
    /// </summary>
    public sealed class ApplicationRole : IdentityRole<Guid>
    {
    }
}
