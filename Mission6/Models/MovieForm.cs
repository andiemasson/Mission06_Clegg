using System.ComponentModel.DataAnnotations;

namespace Mission6.Models;

public class MovieForm
{
    [Key]
    [Required(ErrorMessage = "Category is required")]
    public string Category { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Year is required")]
    [Range(1888, 2100, ErrorMessage = "Enter a valid year")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Director is required")]
    public string Director { get; set; }

    [Required(ErrorMessage = "Rating is required")]
    public string Rating { get; set; }

    public bool? Edited { get; set; } // Nullable to prevent errors

    public string? LentTo { get; set; }
    
    public string? Notes { get; set; }
}


