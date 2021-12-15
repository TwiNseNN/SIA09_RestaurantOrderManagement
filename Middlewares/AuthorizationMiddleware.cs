using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace RestaurantManagementOrder.Middlewares
{
    public class CustomAuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
    {
        private readonly AuthorizationMiddlewareResultHandler
             DefaultHandler = new AuthorizationMiddlewareResultHandler();

        public async Task HandleAsync(
            RequestDelegate requestDelegate,
            HttpContext httpContext,
            AuthorizationPolicy authorizationPolicy,
            PolicyAuthorizationResult policyAuthorizationResult)
        {
            if (policyAuthorizationResult.Challenged)
            {
                httpContext.Response.Redirect($"/Auth/Login?RedirectTo={HttpUtility.UrlEncode(httpContext.Request.Path)}");
                return;
            }
            await DefaultHandler.HandleAsync(requestDelegate, httpContext, authorizationPolicy,
                                   policyAuthorizationResult);
        }

        //bool do_we_show_404_for_this_policy_authorization_result(PolicyAuthorizationResult policyAuthorizationResult)
        //{
        //    return policyAuthorizationResult.Forbidden &&
        //        policyAuthorizationResult.AuthorizationFailure.FailedRequirements.OfType<
        //                                                       Show404Requirement>().Any();
        //}
    }

}