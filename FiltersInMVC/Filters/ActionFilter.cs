using FiltersInMVC.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Net;

namespace FiltersInMVC.Filters
{
    public class ActionFilter : Attribute, IActionFilter
    {
        private readonly ILogger<HomeController> _logger;

        public ActionFilter(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;
            _logger.LogInformation($"[Before] Running action: {actionName}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;
            _logger.LogInformation($"[After] Completed action: {actionName}");
            
        }
    }
}
