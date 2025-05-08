using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    public class BookCreateDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
    }
} 