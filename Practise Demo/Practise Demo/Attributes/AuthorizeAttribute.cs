using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.Attributes
{
    public class AuthorizeAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var loggedIn = context.HttpContext.Request.Cookies.Any(x => x.Key == "auth-demo");
            if (!loggedIn)
            {
                context.Result = new RedirectToActionResult("LIndex", "Login",null);
            }
            base.OnActionExecuting(context);
        }
    }
}
