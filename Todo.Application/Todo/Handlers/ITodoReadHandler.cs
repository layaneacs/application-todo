using System.Collections.Generic;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public interface ITodoReadHandler
    {
        public TodoOutput<List<TodoModel>> Handler();
         
    }
}