using pocmediator.Domain.Responses;
using pocmediator.Domain.Requests;
using MediatR;

namespace Domain.Handlers;

public class CreateHandler : IRequestHandler<CreateRequest, CreateResponse>
{
    private readonly ILogger<CreateHandler> _logger;
    public Task<CreateResponse> Handle(CreateRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var result = new CreateResponse
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Name = "Clarisse",
                Height = 1.80,
                Description = "esguia, magérrima, olhos de esfinge..."
            };
            return Task.FromResult(result);
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, "[CreateHandler] Error while calling task");
            throw;
        }
    }
}