using System;
namespace Todo.Application.Todo
{
    public class TodoOutput<T>
    {
        public Guid IdRequest { get; set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Data { get; set; }
    }
}