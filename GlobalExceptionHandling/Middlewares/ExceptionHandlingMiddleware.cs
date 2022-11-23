using GlobalExceptionHandling.Dto;
using System.Net;
using System.Text.Json;

namespace GlobalExceptionHandling.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = requestDelegate;
            _logger = logger;
        }   

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (KeyNotFoundException ex)
            {
                await HandleExceptionAsync(httpContext, ex.Message, HttpStatusCode.NotFound, "It's immposible... Roberto NOT FOUND!");
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex.Message, HttpStatusCode.NotFound, "Simple exceplion");
            }
        }

        private async Task HandleExceptionAsync(HttpContext httpContext, string exMessage, HttpStatusCode httpStatusCode, string message)
        {
            _logger.LogError(exMessage);

            HttpResponse response = httpContext.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)httpStatusCode;

            ErrorDto errorDto = new()
            {
                Message = message,
                StatusCode = (int)httpStatusCode
            };

            string result = JsonSerializer.Serialize(errorDto);
            await response.WriteAsJsonAsync(result);
        }
    }
}
