using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace FiltersInMVC.Filters
{
    public class ExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is NotImplementedException)
            {
                context.Result = new ViewResult
                {
                    StatusCode = StatusCodes.Status501NotImplemented,
                    ViewName = "Error"
                };
                context.ExceptionHandled = true;
            }
            else if (context.Exception is NotFoundObjectResult)
            {
                context.Result = new ViewResult
                {
                    StatusCode=StatusCodes.Status404NotFound
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
