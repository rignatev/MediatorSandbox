using Mediator;

using MediatorSandbox.App;

using Microsoft.AspNetCore.Mvc;

namespace MediatorSandbox.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestQueryController : ControllerBase
{
    private readonly IMediator _mediator;

    public TestQueryController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Notify([FromQuery] string message)
    {
        string queryResponse = await _mediator.Send(new TestQuery.Query { Message = message });

        return Ok(queryResponse);
    }
}
