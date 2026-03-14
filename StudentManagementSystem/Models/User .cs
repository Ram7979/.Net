using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
       
        public string Role { get; set; }  //(Teacher/ Student)
    }
}
