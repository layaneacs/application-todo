using Todo.Application.Todo.Handlers.Create;
using Todo.Application.Todo.Handlers.Replace;
using Todo.Domain.Todo;

namespace Todo.Application.Todo.Handlers
{
    public interface ITodoWriterHandler
    {
        public TodoOutput<TodoModel> Handler(TodoCreate input);
        public TodoOutput<TodoModel> Handler(TodoReplace input);
    }
}