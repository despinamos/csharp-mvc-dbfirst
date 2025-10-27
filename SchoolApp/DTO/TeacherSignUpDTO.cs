using System.ComponentModel.DataAnnotations;
using SchoolApp.core.enums;

namespace SchoolApp.DTO
{
    public class TeacherSignUpDTO
    {
        [StringLength(50, MinimumLength = 2, ErrorMessage= "Username must be between 2 and 50 characters.")]
        public string? Username { get; set; }

        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [RegularExpression(@"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?\d)(?=.*?\W)^.{8,}$",
            ErrorMessage = "Password must contain at least one uppercase, " +
            "one lowercase, one digit and one special character")]
        public string? Password { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Firstname must be between 2 and 50 characters.")]
        public string? Firstname { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Lastname must be between 2 and 50 characters.")]
        public string? Lastname { get; set; }

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Phone Number must be between 10 and 50 characters.")]
        public string? PhoneNumber { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Institution must be between 2 and 50 characters.")]
        public string? Institution { get; set; }

        [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid user role.")]
        public UserRole? UserRole { get; set; }
    }
}
