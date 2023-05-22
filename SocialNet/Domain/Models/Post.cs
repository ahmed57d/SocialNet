namespace SocialNet.Domain.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<Comment> Comments { get; set; } = new List<Comment>();

    }
}
