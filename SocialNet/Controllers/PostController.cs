using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Repository;
using SocialNet.Service.IService;

namespace SocialNet.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService postService)
        {
            this.postService = postService;
        }
        [HttpGet]
        public IEnumerable<Post> GetAllUsersPosts()
        {
            var posts = postService.GetAllUsersPosts();
            return (IEnumerable<Post>)Ok(posts);
        }
        [HttpGet("{Id:string}", Name = "Id")]
        public IEnumerable<Post> GetUserPosts(string Id)
        {
            var post = postService.GetUserPosts(Id);
            return ((IEnumerable<Post>)Ok(post));
        }
        [HttpPost]
        public void AddPost(Post post)
        {
            postService.AddPost(post);
        }
        [HttpPut]
        public void UpdatePost(Post post)
        {
            postService.UpdatePost(post);
        }
        [HttpDelete]
        public void DeletePost(Post post)
        {
            postService.DeletePost(post);
        }
    }
}
