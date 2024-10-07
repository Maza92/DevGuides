using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevGuides.API.Models
{
    public class Category
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("category_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("category_name")]
        public string Name { get; set; } = null!;

    }
}
