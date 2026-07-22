using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Domain.Common
{
/// <summary>
/// Entidad base para todas las entidades persistentes del sistema.
/// Centraliza información de auditoría y trazabilidad.
/// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        /// <summary>
        /// Fecha de última modificación.
        /// Puede ser nula si la entidad nunca ha sido modificada.
        /// </summary>
        public DateTime CreatedAtUtc { get; protected set; }

        public string? CreatedBy { get; protected set; }

        public DateTime? UpdatedAtUtc { get; protected set; }

        public string? UpdatedBy { get; protected set; }
    }
}
