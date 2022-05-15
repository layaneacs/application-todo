using System;
using Todo.Application.Todo.Handlers.Create;
using Todo.Application.Todo.Handlers.Replace;
using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public class TodoWriterHandler : ITodoWriterHandler
    {
        private readonly ITodoRepository repository;

        public TodoWriterHandler(ITodoRepository repository)
        {
            this.repository = repository;
        }
        public TodoOutput<TodoModel> Handler(TodoCreate input){

            var output = new TodoOutput<TodoModel>(){
                Sucesso = false,
                Mensagem = "Não foi salvo"
            };
            
            //TODO - CRIAR EXTENSIONS PARA FAZER OS MAPPERS
            var parsed = new TodoModel(){
                DataRegistro = System.DateTime.Now,
                Descricao = input.Descricao,
                Status = Domain.ValueObject.Status.NOVO,
                Titulo = input.Titulo,
                Id = System.Guid.NewGuid()
            };

            if(repository.Save(parsed)){
                output.Sucesso = true;
                output.Mensagem = "Salvo com sucesso";
                output.Data = parsed;
                return output;
            }
            return output;
        }

        public TodoOutput<TodoModel> Handler(TodoReplace input)
        {
             var output = new TodoOutput<TodoModel>(){
                Sucesso = false,
                Mensagem = "Não foi possível atualizar"
            };

            var todo = repository.GetById(input.IdTodo);
            if(todo is not null) {
                var inputParsed = new TodoModel()
                {
                    Descricao = input.Descricao,
                    Inicio = DateTime.Today, // adicionar no input
                    Fim = DateTime.Today.AddDays(5),
                    DataRegistro = DateTime.Today,
                    Status = input.Status,
                    Id = input.IdTodo,
                    Titulo = input.Titulo
                };
                repository.Replace(inputParsed);
                output.Mensagem = "Atualização realizada";
                output.Sucesso = true;
                output.Data = inputParsed;
                return output;
            }

            return output;            
        }
    }
}