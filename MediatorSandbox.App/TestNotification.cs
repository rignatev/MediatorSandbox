using Mediator;

namespace MediatorSandbox.App;

public record TestNotification : INotification
{
    public string Message { get; init; } = null!;
}
