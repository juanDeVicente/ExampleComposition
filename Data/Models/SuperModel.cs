namespace Models.Models;

public class SuperModel : IModel
{
    public int Id { get; set; }
    
    public string? Description { get; init; }
    public string? CustomField2 { get; init; }
}