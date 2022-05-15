using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers.Todo
{
    public class Header
    {
        [FromHeader(Name ="X-IDENTIFICADOR")]
        public string IDENTIFICADOR { get; set; }
    }
}