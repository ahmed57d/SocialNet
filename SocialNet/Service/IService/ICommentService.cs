using SocialNet.Domain.Models;

namespace SocialNet.Service.IService
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(Comment comment);
    }
}
