using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.CoreMvc.Models
{
    public class UserViewModel
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required, RegularExpression("")] //TODO regular expression to validate specific email
        public string Email{ get; set; }

        [Required]
        public string Password { get; set; }
    }
}
