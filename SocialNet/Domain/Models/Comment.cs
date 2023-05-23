using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNet.Domain.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        // Foreign key
        public string PostId { get; set; }
        // Navigation property
        public string UserId { get; set; }
    }
}
