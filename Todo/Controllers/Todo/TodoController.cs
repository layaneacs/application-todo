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
using Todo.Application.Todo.Handlers.Replace;
using Todo.Application.Todo.Handlers.Create;

namespace Todo.Controllers.Todo
{
    [ApiController]
    [TypeFilter(typeof(ValidateIdentificatorAttribute))]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoReadHandler getHandler;
        private readonly ITodoWriterHandler postHandler;
        public TodoController(ITodoReadHandler getHandler, ITodoWriterHandler postHandler)
        {
            this.getHandler = getHandler;
            this.postHandler = postHandler;
        }

        [HttpGet("all")]        
        public TodoOutput<List<TodoModel>> GetAll([FromHeader] Header header)
        {
            var input = new TodoInput();
            input.SetIdentificador(header.IDENTIFICADOR);
            return getHandler.Handler();
        }

        [HttpPost("create")]        
        public  TodoOutput<TodoModel> CreateTodo([FromHeader] Header header,[FromBody] TodoCreate input)
        {
            input.SetIdentificador(header.IDENTIFICADOR);
            return postHandler.Handler(input);
        }

        [HttpPost("replace")]        
        public  TodoOutput<TodoModel> ReplaceTodo([FromHeader] Header header,[FromBody] TodoReplace input)
        {
            input.SetIdentificador(header.IDENTIFICADOR);
            return postHandler.Handler(input);
        }
        
    }
}