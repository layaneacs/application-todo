using System.Collections.Generic;
using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public class TodoReadHandler : ITodoReadHandler
    {
        private readonly ITodoRepository repository;

        public TodoReadHandler(ITodoRepository repository)
        {
            this.repository = repository;
        }     

         public TodoOutput<List<TodoModel>> Handler(){   
                    
            return   new TodoOutput<List<TodoModel>>(){
                Data = repository.GetAll(),
                Sucesso = true
            };
        }  
    }
}