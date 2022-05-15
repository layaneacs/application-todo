using System.ComponentModel.DataAnnotations;
using Todo.Domain.ValueObject;

namespace Todo.Application.Todo
{
    public class TodoInput
    {
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Titulo { get; set; }
        public Status Status { get; set; }
        internal string Identificador { get; private set; }

        public void SetIdentificador(string identificador)
        {
            this.Identificador = identificador;
        }
    }
}