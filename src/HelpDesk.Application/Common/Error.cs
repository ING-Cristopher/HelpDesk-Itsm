using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Application.Common
{
    // representa un error que puede ocurrir durante la ejecución de una operación en la aplicación. Contiene un código de error y una descripción del error.
    public sealed record Error(
        string Code,
        string Description);
    
    
}
