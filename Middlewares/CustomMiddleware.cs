namespace SurveyBasket.Middlewares
{
    public class CustomMiddleware
    {
        private readonly ILogger<CustomMiddleware> _logger;
        private readonly RequestDelegate _next;

        public CustomMiddleware(ILogger<CustomMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("custom middleware loging start");
            _logger.LogInformation(context.Request.Method);
            _logger.LogInformation(context.Request.Protocol);
            _logger.LogInformation(context.Request.Host.Host);
            _logger.LogInformation(context.Request.Host.Port.GetType().ToString());

            await _next(context);

            _logger.LogInformation("custom middleware loging end");
        }
    }
}
