using System.Collections.Generic;
using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Infra.Todo.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private static List<TodoModel> listaMockada = new List<TodoModel>(){
            new TodoModel(){
                DataRegistro = System.DateTime.Now,
                Descricao = "Fazer tal coisa 1",
                Status = Domain.ValueObject.Status.NOVO,
                Titulo = "Titulo de tal 1"
            }, 
            new TodoModel(){
                DataRegistro = System.DateTime.Now,
                Descricao = "Fazer tal coisa 2 ",
                Status = Domain.ValueObject.Status.NOVO,
                Titulo = "Titulo de tal 2"
            }
        };

        public TodoRepository()
        {
            
        }
        public List<TodoModel> GetAll()
        {
            return listaMockada;
        }

        public bool Save(TodoModel todo)
        {            
            try{
                listaMockada.Add(todo);
                return true;
            } catch {
                return false;
            }
            
        }
    }
}