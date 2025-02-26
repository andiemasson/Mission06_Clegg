using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6.Models;

public class MovieForm
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Categories? Category { get; set; }
    [Required (ErrorMessage = "Enter a Title")]
    public string? Title { get; set; }

    [Range(1888, 2100, ErrorMessage = "Enter a valid year")]
    public int Year { get; set; }
    public string? Director { get; set; }
    public string? Rating { get; set; }
    [Required (ErrorMessage = "Enter if Edited or not ")]

    public bool? Edited { get; set; } // Nullable to prevent errors

    public string? LentTo { get; set; }
    
    public bool? CopiedToPlex { get; set; }
    
    public string? Notes { get; set; }
}


