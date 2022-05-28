using System.ComponentModel.DataAnnotations;

namespace SarinDemoChatti.Shared.Models
{
    public class MessageInfo
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string? UserName { get; set; }

        [Required]
        public string? Message { get; set; }

        [Required]
        public string? GroupName { get; set; }
    }
}
