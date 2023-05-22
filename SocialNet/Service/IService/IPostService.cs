using SocialNet.Domain.Models;

namespace SocialNet.Service.IService
{
    public interface IPostService
    {
        Task<Post> GetUserPosts(string Id);
        IEnumerable<Post> GetAllUsersPosts();
    }
}
