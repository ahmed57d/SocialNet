using Microsoft.AspNetCore.Mvc;
using SocialNet.Domain.Models;
using SocialNet.Service;
using SocialNet.Service.IService;

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
        public IActionResult AddComment([FromBody] Comment comment)
        {
            commentService.AddComment(comment);
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateComment([FromBody] Comment comment)
        {
            commentService.UpdateComment(comment);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteComment([FromBody] Comment comment)
        {
            commentService.DeleteComment(comment);
            return NoContent();
        }

    }
}
