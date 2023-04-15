using Mediator;

using Microsoft.Extensions.Logging;

namespace MediatorSandbox.App;

public class TestNotificationHandler1 : INotificationHandler<TestNotification>
{
    private readonly ILogger<TestNotificationHandler1> _logger;

    public TestNotificationHandler1(ILogger<TestNotificationHandler1> logger) => _logger = logger;

    /// <inheritdoc />
    public ValueTask Handle(TestNotification notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("NotificationHandler1 {Message}", notification.Message);

        return ValueTask.CompletedTask;
    }
}
