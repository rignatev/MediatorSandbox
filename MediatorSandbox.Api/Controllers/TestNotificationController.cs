using MediatorSandbox.App;

using Microsoft.AspNetCore.Mvc;

namespace MediatorSandbox.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestNotificationController : ControllerBase
{
    private readonly Mediator.Mediator _mediator;
    private readonly ILogger<TestNotificationController> _logger;

    public TestNotificationController(Mediator.Mediator mediator, ILogger<TestNotificationController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Notify([FromBody] string message)
    {
        await _mediator.Publish(new TestNotification { Message = message });

        return Ok();
    }
}
