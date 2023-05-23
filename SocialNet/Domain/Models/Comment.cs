using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNet.Domain.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        // Foreign key
        [ForeignKey("Post")]
        public string PostId { get; set; }
        // Navigation property
        public string CommenterId { get; set; }
    }
}
