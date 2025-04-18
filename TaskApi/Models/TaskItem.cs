using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле Title обязательно")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле Description обязательно")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле Status обязательно")]
        public string Status { get; set; } = "Pending";
    }
}
