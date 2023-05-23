using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service;
using SocialNet.Service.IService;
using Microsoft.AspNetCore.Authorization;

namespace SocialNet.Controllers
{
    [ApiController]
    [Route("api/comments")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddComment([FromBody] Comment comment)
        {
            commentService.AddComment(comment);
            return Ok();
        }

        [HttpPut]
        [Authorize]
        public IActionResult UpdateComment([FromBody] Comment comment)
        {
            commentService.UpdateComment(comment);
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public IActionResult DeleteComment([FromBody] Comment comment)
        {
            commentService.DeleteComment(comment);
            return NoContent();
        }
    }
}
