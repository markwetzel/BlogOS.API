using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogOS.API.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentID { get; set; }

        [Required]
        [ForeignKey("Post")]
        public int PostID { get; set; }

        [ForeignKey("User")]
        public int? UserID { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Approved { get; set; }

        public Post Post { get; set; }

        public User User { get; set; }
    }
}
