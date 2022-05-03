using System.Collections.Generic;
using Todo.Domain.Todo;

namespace Todo.Domain.Service
{
    public interface IIdentificadorService
    {
        public bool IsValid(string identificador);
    }
}