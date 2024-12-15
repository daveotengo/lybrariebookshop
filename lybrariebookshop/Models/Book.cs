using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lybrariebookshop.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        // Foreign key for Author
        public long AuthorId { get; set; }

        // Navigation property for Author
        public Author? Author { get; set; }

        // Foreign key for Genre
        public long GenreId { get; set; }

        // Navigation property for Genre
        public Genre? Genre { get; set; }

        [Required]
        [StringLength(45)]
        public string? Title { get; set; }

        [Required]
        [StringLength(5)]
        public string? Year { get; set; }

        [Required]
        [StringLength(20)]
        public string? Isbn { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public Book()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}