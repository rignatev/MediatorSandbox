using Mediator;

using Microsoft.Extensions.Logging;

namespace MediatorSandbox.App;

public sealed class GenericNotificationHandler<TNotification> : INotificationHandler<TNotification>
    where TNotification : INotification // Generic notification handlers will be registered as open constrained types automatically
{
    private readonly ILogger<GenericNotificationHandler<TNotification>> _logger;

    public GenericNotificationHandler(ILogger<GenericNotificationHandler<TNotification>> logger) => _logger = logger;

    public ValueTask Handle(TNotification notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("GenericNotificationHandler {MessageType}", notification.GetType().Name);

        return default;
    }
}
