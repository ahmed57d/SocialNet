using SocialNet.Domain.Models;
using SocialNet.Repository.IRepository;
using SocialNet.Service.IService;

namespace SocialNet.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public void AddComment(Comment comment)
        {
            commentRepository.AddComment(comment);
        }

        public void DeleteComment(Comment comment)
        {
            commentRepository.DeleteComment(comment);
        }

        public void UpdateComment(Comment comment)
        {
            commentRepository.UpdateComment(comment);
        }
    }
}
