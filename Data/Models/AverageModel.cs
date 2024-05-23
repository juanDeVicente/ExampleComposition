namespace Models.Models;

public class AverageModel : IModel
{
    public int Id { get; set; }
    
    public string? Description { get; init; }
    public string? CustomField1 { get; init; }
}