using SocialNet.Domain.Models;

namespace SocialNet.Repository.IRepository
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
        void SaveChanges();
    }
}
