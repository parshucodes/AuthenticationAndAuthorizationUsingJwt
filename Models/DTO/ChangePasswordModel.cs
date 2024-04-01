using System.ComponentModel.DataAnnotations;

namespace jwtagain.Models.DTO
{
    public class ChangePasswordModel
    {
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
