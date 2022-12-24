using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_Store.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Category Id must be at least 5 characters and start with letter 'C'")]
        [RegularExpression("^(C)[a-z,A-Z]*[0-9]{1,}")]
        public string CatId { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = " Category name must be at least 1 character.")]
        [MaxLength(30, ErrorMessage = "Category name less than 30 characters.")]
        public string CatName { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Category description must be at least 10 character.")]
        public string CatDescription { get; set; }
        
        public int Status { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
