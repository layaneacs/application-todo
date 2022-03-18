using System.Collections.Generic;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public interface IGetTodoHandler
    {
        public TodoOutput<List<TodoModel>> Handler();
         
    }
}