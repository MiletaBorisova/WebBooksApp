using System.ComponentModel.DataAnnotations;
using WebBooksApp.Models.Enum;

namespace WebBooksApp.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Author { get; set; }

        public Category Category { get; set; }
        public string? Picture { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Description { get; set; }

        [Required]
        [Range(0, 100.00)]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }



    }
}
