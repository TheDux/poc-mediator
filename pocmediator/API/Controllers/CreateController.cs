using Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using pocmediator.Domain.Requests;
using pocmediator.Domain.Responses;

namespace pocmediator.API.Controllers;

[ApiController]
[Route("v1/api")]
public class CreateController : ControllerBase
{
    [HttpPost]
    [Route("create")]
    public async Task<CreateResponse> Create(
        [FromServices] IMediator mediator,
        [FromBody] CreateRequest command
        )
    {
        var response = await mediator.Send(command);
        return response;
    }

    [HttpGet]
    [Route("get")]
    public CreateResponse Get(
        [FromServices] GetHandler handler)
    {
        var response = handler.Handle();
        return response;
    }
}