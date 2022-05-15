using Todo.Domain.ValueObject;
using System;

namespace Todo.Domain.Todo
{
    public class TodoModel
    {
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public Status Status { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Guid Id { get; set; }

    }
}