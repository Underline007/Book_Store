using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class StoreOwner
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "At least 1 character.")]
        [MaxLength(20, ErrorMessage = "Lees 20 characters.")]
        public string SName { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone must be have 10 digits.")]
        public string SPhone { get; set; }

        [Required]
        public char SGender { get; set; }

        [Required]
        public string SPicture { get; set; }
    }
}

