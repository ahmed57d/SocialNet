using SocialNet.Domain.Models;
using SocialNet.Repository.Contexts;
using SocialNet.Repository.IRepository;

namespace SocialNet.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext context;
        public CommentRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void AddComment(Comment comment)
        {
            var post = context.Posts.Find(comment.PostId);
            if (post != null)
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
        public void UpdateComment(Comment comment)
        {
            context.Update(comment);
            context.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            context.Remove(comment);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        
    }
}
