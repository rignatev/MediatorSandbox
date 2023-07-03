using Mediator;

using MediatorSandbox.App;

using Microsoft.AspNetCore.Mvc;

namespace MediatorSandbox.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestNotificationController : ControllerBase
{
    private readonly IMediator _mediator;

    public TestNotificationController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Notify([FromBody] string message)
    {
        await _mediator.Publish(new TestNotification { Message = message });

        return Ok();
    }
}
