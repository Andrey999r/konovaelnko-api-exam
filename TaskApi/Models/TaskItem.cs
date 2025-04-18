using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [RegularExpression("New|InProgress|Done", ErrorMessage = "Status must be New, InProgress or Done")]
        public string Status { get; set; }
    }
}
