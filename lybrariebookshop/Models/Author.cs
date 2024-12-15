using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lybrariebookshop.Models
{
    [Table("Authors")]
    public class Author
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        [StringLength(25)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(25)]
        public string? LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string? UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }

/*        public ICollection<Book> Books { get; set; } = new List<Book>();
*/        public Author()
        {
            CreateDate = DateTime.UtcNow;
        }
    }
}
