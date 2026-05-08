using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ECommerceMVCFiltersApp.Services;

namespace ECommerceMVCFiltersApp.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly LoggingService _loggingService;

        public GlobalExceptionFilter(LoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnException(ExceptionContext context)
        {
            _loggingService.Log(
                $"Error: {context.Exception.Message}"
            );

            context.Result = new ViewResult
            {
                ViewName = "Error"
            };

            context.ExceptionHandled = true;
        }
    }
}