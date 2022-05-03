using Todo.Application.Todo;
using Todo.Application.Todo.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Domain.Todo;
using Todo.Controllers.Attribute.Filter;

namespace Todo.Controllers.Todo
{
    [ApiController]
    [TypeFilter(typeof(ValidateIdentificatorAttribute))]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IGetTodoHandler getHandler;
        private readonly IPostTodoHandler postHandler;
        public TodoController(IGetTodoHandler getHandler, IPostTodoHandler postHandler)
        {
            this.getHandler = getHandler;
            this.postHandler = postHandler;
        }

        [HttpGet]        
        public TodoOutput<List<TodoModel>> GetAll([FromHeader] Header header)
        {
            var input = new TodoInput();
            input.SetIdentificador(header.IDENTIFICADOR);
            return getHandler.Handler();
        }

        [HttpPost]        
        public  TodoOutput<bool> CreateTodo([FromHeader] Header header,[FromBody] TodoInput input)
        {
            input.SetIdentificador(header.IDENTIFICADOR);
            return postHandler.Handler(input);
        }
        
    }
}