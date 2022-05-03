using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Todo.Controllers.Attribute.Filter
{
    public class ValidateIdentificatorAttribute : ActionFilterAttribute
    {
         public override void OnActionExecuting(ActionExecutingContext context)
        {
            var identificador = context.HttpContext.Request.Headers["X-IDENTIFICADOR"].ToString();

            if (identificador is null || string.IsNullOrEmpty(identificador))
            {
                context.Result = new BadRequestObjectResult("IDENTIFICADOR não encontrado");
                return;
            }

            //-- TODO; 
            //verificar se o identificador é válido ( IdentificadorService )
        }
        
    }
}

// REF: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-6.0#action-filters