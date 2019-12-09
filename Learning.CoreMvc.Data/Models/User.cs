using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Learning.CoreMvc.Data.Constants;
using Learning.CoreMvc.Data.Models.Interfaces;

namespace Learning.CoreMvc.Data.Models
{
    public class User : IGuidBasedEntity
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = ConstraintsMessages.MaxLengthFirstAndLastName)]
        public string FirstName { get; set; }

        [MaxLength(50, ErrorMessage = ConstraintsMessages.MaxLengthFirstAndLastName)]
        public string LastName { get; set; }

        [Required] 
        [MaxLength(150, ErrorMessage = ConstraintsMessages.MaxLengthEmail)]
        public string Email { get; set; }

        public string HashedPassword { get; set; }

        public string Salt { get; set; }
    }
}
