namespace Baski.Authentication.Models
{

    public class ChangePasswordModel
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class UserProfileModel
    {
        public string Name { get; set; }
        public int BirthDate{ get; set; }
        public int Country { get; set; }
        public int Ethnicity { get; set; }
        public string ZipCode { get; set; }
    }
    
}
