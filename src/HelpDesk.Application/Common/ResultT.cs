using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDesk.Application.Common
{
    public class Result<T> : Result
    {
        /// <summary>
        /// Resultado genérico que encapsula un valor cuando
        /// la operación fue exitosa.
        /// </summary>
        private Result(T? value, bool isSuccess, Error? error) : base(isSuccess, error)
        {
            Value = value;
        }
        /// <summary>
        /// Valor retornado por la operación.
        /// Será nulo cuando la operación falle.
        /// </summary>
        public T? Value { get;  }

        public static Result<T> Success(T value) => new(value, true, null);

        public static new Result<T> Failure(Error error) => new(default, false, error);
    }
}
