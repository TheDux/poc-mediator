using pocmediator.Domain.Responses;
using pocmediator.Domain.Requests;

namespace Domain.Handlers;

public interface ICreateHandler
{
    public CreateResponse Handle(CreateRequest request);
}