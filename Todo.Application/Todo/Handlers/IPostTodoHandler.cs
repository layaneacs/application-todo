namespace Todo.Application.Todo.Handlers
{
    public interface IPostTodoHandler
    {
        public TodoOutput<bool> Handler(TodoInput input);
    }
}