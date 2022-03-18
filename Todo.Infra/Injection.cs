using Microsoft.Extensions.DependencyInjection;
using Todo.Infra.Todo.Repository;
using Todo.Domain.Repository;

namespace Todo.Infra
{
    public static class Injection
    {
        public static IServiceCollection AddInfra(this IServiceCollection service)
        {
            service.AddScoped<ITodoRepository, TodoRepository>();
            return service;
        }
        
    }
}