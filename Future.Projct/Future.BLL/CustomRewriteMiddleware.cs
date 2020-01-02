using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Future.BLL
{
    public class CustomRewriteMiddleware
    {
        private readonly RequestDelegate _next;

        //Your constructor will have the dependencies needed for database access
        public CustomRewriteMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var path = context.Request.Path.ToUriComponent().ToLowerInvariant();
            var thingid = context.Request.Query["thingid"].ToString();
            var parm = path.Replace("/", "");
            QueryString qString = new QueryString("?test=" + parm);
            context.Request.QueryString = qString;
           // var templateController = GetControllerByThingid(thingid);
            var pathnew = @"/home/index";
            context.Request.Path = pathnew;
            await _next.Invoke(context);

        }
    }
}
