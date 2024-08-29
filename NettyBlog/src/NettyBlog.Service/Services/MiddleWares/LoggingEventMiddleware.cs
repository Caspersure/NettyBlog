namespace NettyBlog.Service.Services.MiddleWares;

/// <summary>
/// middleware for logging
/// </summary>
/// <typeparam name="TEvent"></typeparam>
public class LoggingEventMiddleware<TEvent> : EventMiddleware<TEvent>
    where TEvent : IEvent
{
    private readonly ILogger<LoggingEventMiddleware<TEvent>> _logger;
    /// <summary>
    /// inject logger
    /// </summary>
    /// <param name="logger"></param>
    public LoggingEventMiddleware(ILogger<LoggingEventMiddleware<TEvent>> logger) => _logger = logger;

    public override async Task HandleAsync(TEvent @event, EventHandlerDelegate next)
    {
        _logger.LogInformation("----- Handling command {CommandName} ({@Command})", @event.GetType().GetGenericTypeName(), @event);
        await next();
    }
}