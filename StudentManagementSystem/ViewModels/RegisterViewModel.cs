namespace StudentManagementSystem.ViewModels
{
    public class RegisterViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}