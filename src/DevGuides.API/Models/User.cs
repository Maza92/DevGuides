using DevGuides.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevGuides.API.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("full_name")]
        public string FullName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Column("user_email")]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Column("user_password")]
        public string Password { get; set; } = null!;

        [Column("user_role")]
        public Role Role { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

    }
}
