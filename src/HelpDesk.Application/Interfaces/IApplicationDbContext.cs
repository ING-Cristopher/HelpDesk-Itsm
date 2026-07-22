using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Application.Interfaces
{
    /// <summary>
    /// Contracto de acceso a persistencia de datos para la aplicación.
    /// Permite desacopiar apllicaation de Entity Framework y facilita la prueba de la lógica de negocio.
    /// </summary>
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
