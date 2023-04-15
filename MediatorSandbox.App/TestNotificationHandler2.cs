using Mediator;

using Microsoft.Extensions.Logging;

namespace MediatorSandbox.App;

public class TestNotificationHandler2 : INotificationHandler<TestNotification>
{
    private readonly ILogger<TestNotificationHandler2> _logger;

    public TestNotificationHandler2(ILogger<TestNotificationHandler2> logger) => _logger = logger;

    /// <inheritdoc />
    public async ValueTask Handle(TestNotification notification, CancellationToken cancellationToken)
    {
        await Task.Delay(10000, cancellationToken);

        _logger.LogInformation("NotificationHandler2 {Message}", notification.Message);
    }
}
