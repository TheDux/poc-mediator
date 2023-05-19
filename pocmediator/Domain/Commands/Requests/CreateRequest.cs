using System;

namespace pocmediator.Domain.Requests;

public class CreateRequest
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public double Height { get; set; }
    public string? Description { get; set; }
}