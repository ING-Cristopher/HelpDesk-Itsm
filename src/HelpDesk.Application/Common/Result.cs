using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Application.Common
{
    /// <summary>
    /// Representa el resultado de una operación.
    /// Permite manejar errores de negocio sin utilizar excepciones.
    /// </summary>
    public class Result
    {
        protected Result(bool isSuccess, Error? error)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; }

        public bool IsFailure => !IsSuccess;

        public Error? Error { get; }

        public static Result Success() => new(true, null);

        public static Result Failure(Error error) => new(false, error);
    }
}
