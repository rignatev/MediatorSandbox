using Mediator;

namespace MediatorSandbox.App;

public static class TestQuery
{
    public class Handler : IQueryHandler<Query, string>
    {
        /// <inheritdoc />
        public ValueTask<string> Handle(Query query, CancellationToken cancellationToken) => new($"Handled message: {query.Message}");
    }

    public record Query : IQuery<string>
    {
        public string Message { get; init; } = null!;
    }
}
