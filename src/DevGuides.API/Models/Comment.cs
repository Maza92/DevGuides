using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevGuides.API.Models
{
    public class Comment
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("comment_id")]
        public int Id { get; set; }

        [Column("comment_content")]
        public string Content { get; set; } = null!;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("comment_author_id")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public User? Author { get; set; } = null!;

        [Column("comment_publication_id")]
        public int PublicationId { get; set; }

        [ForeignKey(nameof(PublicationId))]
        public Publication Publication { get; set; } = null!;

    }
}
