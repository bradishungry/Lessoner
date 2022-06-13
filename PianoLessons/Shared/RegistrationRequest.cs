using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoLessons.Shared
{
    public class RegistrationRequest
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [Compare("Email",
        ErrorMessage = "Email and Confirm Email must match")]
        public string? ConfirmEmail { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
         ErrorMessage = "Password must have minimum eight characters, at least one letter and one number")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password",
        ErrorMessage = "Password and Confirm Password must match")]
        public string? ConfirmPassword { get; set; }

        [Required]
        public bool IsTeacher { get; set; }

        // TODO(Bradley): Add Captcha here
        public string? CaptchaResp { get; set; }
    }
}
