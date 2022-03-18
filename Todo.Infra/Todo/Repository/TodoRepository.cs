using System.Collections.Generic;
using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Infra.Todo.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private static List<TodoModel> lista = new List<TodoModel>(){
            new TodoModel(){
                DataRegistro = System.DateTime.Now,
                Descricao = "Fazer tal coisa",
                Status = Domain.ValueObject.Status.NOVO,
                Titulo = "Titulo de tal"
            }
        };

        public TodoRepository()
        {
            
        }
        public List<TodoModel> GetAll()
        {
            return lista;
        }

        public bool Save(TodoModel todo)
        {            
            try{
                lista.Add(todo);
                return true;
            } catch {
                return false;
            }
            
        }
    }
}