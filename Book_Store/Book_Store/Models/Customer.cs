using System;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(1, ErrorMessage = "Name length must be at least 1 character.")]
        [MaxLength(20, ErrorMessage = "Name should not exceed 20 characters.")]
        public string CName { get; set; }

        [Required]
        public string CAddress { get; set; }
  
        [Required]
        [EmailAddress]
        public string CEmail { get; set; }

        [Required]
        public char CGender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CBirthday { get; set; }

        [Required]
        public string CPhoneNumber { get; set; }

        [Required]
        public string CPicture { get; set; }
    }
}
