using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace FiltersInMVC.Filters
{
    public class ResourceFilter : Attribute, IResourceFilter
    {
        private static readonly Dictionary<string, IActionResult> _cache
         = new Dictionary<string, IActionResult>();

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            var path = context.HttpContext.Request.Path;

            if (_cache.ContainsKey(path))
            {
                context.Result = _cache[path];
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            var path = context.HttpContext.Request.Path;

            if (context.Result != null && !_cache.ContainsKey(path))
            {
                _cache[path] = context.Result;
            }
        }
    }
}
