using Domain.Handlers;
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
    public CreateResponse Create(
        [FromServices] ICreateHandler handler,
        [FromBody] CreateRequest command
        )
    {
        var response = handler.Handle(command);
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