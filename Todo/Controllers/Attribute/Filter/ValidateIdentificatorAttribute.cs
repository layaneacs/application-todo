using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Todo.Domain.Service;

namespace Todo.Controllers.Attribute.Filter
{
    public class ValidateIdentificatorAttribute : ActionFilterAttribute
    {
        private readonly IIdentificadorService _service;

        public ValidateIdentificatorAttribute(IIdentificadorService service)
        {
            _service = service;
        }
         public override void OnActionExecuting(ActionExecutingContext context)
        {
            var identificador = context.HttpContext.Request.Headers["X-IDENTIFICADOR"].ToString();

            if (identificador is null || string.IsNullOrEmpty(identificador))
            {
                context.Result = new BadRequestObjectResult("IDENTIFICADOR não encontrado");
                return;
            }

            var isValid = _service.IsValid(identificador);

            if (!isValid)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
        
    }
}

// REF: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-6.0#action-filters