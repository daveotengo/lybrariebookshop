using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lybrariebookshop.Models
{
    [Table("Genres")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(45)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

/*        public ICollection<Book> Books { get; set; } = new List<Book>();
*/        public Genre()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}
