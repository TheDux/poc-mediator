namespace pocmediator.Domain.Responses;

public class CreateResponse{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public double Height { get; set; }
    public string? Description { get; set; }
}