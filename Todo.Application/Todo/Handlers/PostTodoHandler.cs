using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public class PostTodoHandler : IPostTodoHandler
    {
        private readonly ITodoRepository repository;

        public PostTodoHandler(ITodoRepository repository)
        {
            this.repository = repository;
        }
        
        public TodoOutput<bool> Handler(TodoInput input){
            var output = new TodoOutput<bool>(){
                Sucesso = false,
                Mensagem = "Não foi salvo"
            };
            if(input.Identificador == null){
                output.Mensagem = "Sem IDENTIFICADOR";
                return output;
            };

            var parsed = new TodoModel(){
                DataRegistro = System.DateTime.Now,
                Descricao = input.Descricao,
                Status = Domain.ValueObject.Status.NOVO,
                Titulo = input.Titulo
            };

            if(repository.Save(parsed)){
                output.Sucesso = true;
                output.Mensagem = "Salvo com sucesso";
                return output;
            }
            return output;
        }
    }
}