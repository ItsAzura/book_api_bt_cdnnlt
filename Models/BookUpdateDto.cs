using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class BookUpdateDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
    }
} 