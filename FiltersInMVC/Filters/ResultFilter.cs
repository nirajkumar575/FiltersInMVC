using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace FiltersInMVC.Filters
{
    public class ResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {

            context.HttpContext.Response.Headers.Append("X-App-Version", "1.0.0");
            context.HttpContext.Response.Headers.Append("X-Developer", "Niraj Kumar");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine($"OnResultExecuted");
        }
    }
}
