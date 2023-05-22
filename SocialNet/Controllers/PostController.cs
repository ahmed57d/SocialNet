using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service.IService;

namespace SocialNet.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet]
        public IActionResult GetAllUsersPosts()
        {
            var posts = postService.GetAllUsersPosts();
            return Ok(posts);
        }

        [HttpGet("{Id}", Name = "PostId")]
        public IActionResult GetUserPosts(string Id)
        {
            var post = postService.GetUserPosts(Id);
            return Ok(post);
        }

        [HttpPost]
        public IActionResult AddPost([FromBody] Post post)
        {
            postService.AddPost(post);
            return CreatedAtRoute("PostId", new { Id = post.Id }, post);
        }

        [HttpPut]
        public IActionResult UpdatePost([FromBody] Post post)
        {
            postService.UpdatePost(post);
            return NoContent();
        }
        [HttpDelete]
        public void DeletePost(Post post)
        {
            postService.DeletePost(post);
        }
    }
}
