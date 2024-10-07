using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevGuides.API.Models
{
    public class Tag
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("tag_id")]
        public int Id { get; set; }

        [Required]
        [Column("tag_name")]
        public string Name { get; set; } = null!;

        public ICollection<Publication> Publications { get; set; } = null!;
    }
}
