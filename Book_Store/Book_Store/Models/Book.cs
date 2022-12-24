using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }

        [MinLength(3)]
        [RegularExpression("^(F)[a-z,A-Z]*[0-9]{1,}", ErrorMessage = "Book ID must be at least 3 characters and start with letter 'F'.")]
        public string BookId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Name length must be at least 1 character.")]
        [MaxLength(30, ErrorMessage = "Name should not exceed 30 characters.")]
        public string BName { get; set; }

        [Required]
        [Range(0, 50, ErrorMessage = "Price needs less than $50.")]
        public double BPrice { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Quantity needs to be less than 1000.")]
        public int BQuantity { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "The description must be at least 10 characters.")]
        public string BDescription { get; set; }


        [Required]
        public string BPicture { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Name length must be at least 1 character.")]
        [MaxLength(30, ErrorMessage = "Name should not exceed 50 characters.")]
        public string BAuthor { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
