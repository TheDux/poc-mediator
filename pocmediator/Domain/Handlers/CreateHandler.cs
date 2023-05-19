using pocmediator.Domain.Responses;
using pocmediator.Domain.Requests;

namespace Domain.Handlers;

public class CreateHandler : ICreateHandler
{
    public CreateResponse Handle(CreateRequest request){

        return new CreateResponse{
            Id = Guid.NewGuid(),
            Date=DateTime.Now,
            Name="Clarisse",
            Height=1.80,
            Description="esguia, magérrima, olhos de esfinge..."
        };
    }
}