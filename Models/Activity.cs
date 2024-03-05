using System.ComponentModel.DataAnnotations;

namespace CyclingApi.Models;

public class Activity
{
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
}