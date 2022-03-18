using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers.Todo
{
    public class Header
    {
        [FromHeader]
        public string IDENTIFICADOR { get; set; }
    }
}