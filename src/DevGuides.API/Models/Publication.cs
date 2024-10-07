using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevGuides.API.Models
{
    public class Publication
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("publication_id")]
        public int Id { get; set; }

        [Required]
        [Column("publication_title")]
        public string Title { get; set; } = null!;

        [Required]
        [Column("publication_content")]
        public string Content { get; set; } = null!;

        [Required]
        [Column("publication_summary")]
        public string Summary { get; set; } = null!;

        [Column("publication_author_id")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; } = null!;

        [Column("publication_category_id")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<Tag> Tags { get; set; } = null!;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
