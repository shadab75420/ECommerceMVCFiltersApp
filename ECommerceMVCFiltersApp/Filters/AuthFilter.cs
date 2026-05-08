using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ECommerceMVCFiltersApp.Services;

namespace ECommerceMVCFiltersApp.Filters
{
    public class AuthFilter : IActionFilter
    {
        private readonly AuthService _authService;

        public AuthFilter(AuthService authService)
        {
            _authService = authService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            bool isLoggedIn = _authService.IsUserLoggedIn();

            if (!isLoggedIn)
            {
                context.Result = new ContentResult
                {
                    Content = "User not authenticated"
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}