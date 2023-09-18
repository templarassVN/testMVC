
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Test.filters {
	public class TokenAuthorizationFilter : IAuthorizationFilter {
		public void OnAuthorization(AuthorizationFilterContext context){
			if(context.HttpContext.Request.Cookies.ContainsKey("Bearer"))
				context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
		}
	}

    public class TokenResultFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Cookies.Append("Bearer", "eqwe213");
        }
    }
}