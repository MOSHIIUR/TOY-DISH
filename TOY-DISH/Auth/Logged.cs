using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Filters;

namespace TOY_DISH.Auth
{
    [EnableCors("*", "*", "*")]
    public class Logged : AuthorizationFilterAttribute
    {
        //return type void? why?
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //this methos is the reason of void methods
            //it passes the `actionContext` to its parent `AuthorizationFilterAttribute`
            //base.OnAuthorization(actionContext);

            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response =
                    actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Msg = "No token supplied" });
            }
            else if (!AuthService.IsTokenValid(token.ToString()))
            {
                actionContext.Response =
                    actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Msg = "Supplied token is invalid or expired" });
            }
            base.OnAuthorization(actionContext);
        }

    }
}