using System.ComponentModel.DataAnnotations;

namespace Learning.CoreMvc.ViewModels
{
    public class UserViewModel
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email{ get; set; }
    }
}
