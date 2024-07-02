using System.ComponentModel.DataAnnotations;

namespace ADP.JKR.Example.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

