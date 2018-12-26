using System.ComponentModel.DataAnnotations;

namespace Lab1
{
    /// <summary>
    /// Жанр
    /// </summary>
    public class Style
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Str { get; set; }
    }
}
