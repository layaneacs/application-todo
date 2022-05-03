using Microsoft.Extensions.DependencyInjection;
using Todo.Infra.Todo.Repository;
using Todo.Domain.Repository;
using Todo.Infra.Todo.Service;
using Todo.Domain.Service;

namespace Todo.Infra
{
    public static class Injection
    {
        public static IServiceCollection AddInfra(this IServiceCollection service)
        {
            service.AddScoped<ITodoRepository, TodoRepository>();
            service.AddScoped<IIdentificadorService, IdentificadorService>();
            return service;
        }
        
    }
}