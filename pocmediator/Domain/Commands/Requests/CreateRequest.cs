using System;
using MediatR;
using pocmediator.Domain.Responses;

namespace pocmediator.Domain.Requests;

public class CreateRequest : IRequest<CreateResponse>
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public double Height { get; set; }
    public string? Description { get; set; }
}