using SocialNet.Domain.Models;
using SocialNet.Repository.IRepository;
using SocialNet.Service.IService;

namespace SocialNet.Service
{
    public class PostService : IPostService
    {
        private IPostRepository postRepository;
        public PostService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IEnumerable<Post> GetAllUsersPosts()
        {
            return postRepository.GetAllUsersPosts();
        }

        public Task<Post> GetUserPosts(string Id)
        {
            return postRepository.GetUserPosts(Id);
        }
    }
}
