using System.Collections.Generic;
using Todo.Domain.Repository;
using Todo.Domain.Service;
using Todo.Domain.Todo;

namespace Todo.Infra.Todo.Service
{
    public class IdentificadorService : IIdentificadorService
    {
        private List<string> valuesMockado = new List<string>(){"LC.5677", "LC.5678", "AB.5677"};
        public bool IsValid(string identificador)
        {
            if(valuesMockado.Contains(identificador))
            {
                return true;
            }
            return false;
        }
    }

}