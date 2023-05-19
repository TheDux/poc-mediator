using pocmediator.Domain.Responses;
using pocmediator.Domain.Requests;

namespace Domain.Handlers;

public class GetHandler
{
    public CreateResponse Handle(){

        return new CreateResponse{
            Id = Guid.NewGuid(),
            Date=DateTime.Now,
            Name="Clarisse",
            Height=1.80,
            Description="esguia, magérrima, olhos de esfinge..."
        };
    }
}