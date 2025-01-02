using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title Can't be empty.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title length should be between 3 and 100 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created {  get; set; } = DateTime.Now;
    }
}
