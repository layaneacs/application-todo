using Microsoft.Extensions.DependencyInjection;
using Todo.Application.Todo.Handlers;

namespace Todo.Application
{
    public static class Injection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddScoped<ITodoReadHandler,TodoReadHandler>();
            service.AddScoped<ITodoWriterHandler, TodoWriterHandler>();
            
            return service;
        }
        
    }
}