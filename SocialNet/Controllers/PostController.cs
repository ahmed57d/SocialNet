using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service.IService;
using Microsoft.AspNetCore.Authorization;

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
        [Authorize]
        public IActionResult GetAllUsersPosts()
        {
            var posts = postService.GetAllUsersPosts();
            return Ok(posts);
        }

        [HttpGet("{Id}", Name = "PostId")]
        [Authorize]
        public IActionResult GetUserPosts(string Id)
        {
            var post = postService.GetUserPosts(Id);
            return Ok(post);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddPost([FromBody] Post post)
        {
            postService.AddPost(post);
            return CreatedAtRoute("PostId", new { Id = post.Id }, post);
        }

        [HttpPut]
        [Authorize]
        public IActionResult UpdatePost([FromBody] Post post)
        {
            postService.UpdatePost(post);
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public IActionResult DeletePost(Post post)
        {
            postService.DeletePost(post);
            return NoContent();
        }
    }
}
