using Mediator;

using Microsoft.Extensions.Logging;

namespace MediatorSandbox.App;

public class TestNotificationHandler3 : INotificationHandler<TestNotification>
{
    private readonly ILogger<TestNotificationHandler3> _logger;

    public TestNotificationHandler3(ILogger<TestNotificationHandler3> logger) => _logger = logger;

    /// <inheritdoc />
    public ValueTask Handle(TestNotification notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("NotificationHandler3 {Message}", notification.Message);

        return ValueTask.CompletedTask;
    }
}
