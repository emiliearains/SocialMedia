using SocialMedia.Services;
using SocialMedia.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocialMedia.WebAPI.Controllers
{
    public class CommentController : ApiController
    {
        public IHttpActionResult Get(PostAndComments postId)
        {
            CommentService commentService = CreateCommentService();
            var comments = commentService.GetComments(postId);
            return Ok(comments);
        }
      
       
        public IHttpActionResult Post(CreateComment comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(comment))
                return InternalServerError();

            return Ok();
        }
        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var commentSerivce = new CommentService(userId);
            return commentSerivce;
        }
    }
}
