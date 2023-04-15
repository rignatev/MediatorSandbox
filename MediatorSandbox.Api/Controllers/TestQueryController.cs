using MediatorSandbox.App;

using Microsoft.AspNetCore.Mvc;

namespace MediatorSandbox.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestQueryController : ControllerBase
{
    private readonly Mediator.Mediator _mediator;
    private readonly ILogger<TestQueryController> _logger;

    public TestQueryController(Mediator.Mediator mediator, ILogger<TestQueryController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Notify([FromQuery] string message)
    {
        var queryResponse = await _mediator.Send(new TestQuery.Query { Message = message });

        return Ok(queryResponse);
    }
}
