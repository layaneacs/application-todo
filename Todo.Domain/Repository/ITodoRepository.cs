using System.Collections.Generic;
using Todo.Domain.Todo;

namespace Todo.Domain.Repository
{
    public interface ITodoRepository
    {
        public bool Save(TodoModel todo);
        public List<TodoModel> GetAll();
    }
}