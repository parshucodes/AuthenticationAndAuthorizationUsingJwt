﻿using System.ComponentModel.DataAnnotations;

namespace jwtagain.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password  { get; set; }
        public string? Name { get; set; }
    }
}
