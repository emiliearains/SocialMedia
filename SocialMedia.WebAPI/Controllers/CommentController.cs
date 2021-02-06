using SocialMedia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

// TO-DO: get comments by postID

namespace SocialMedia.WebAPI.Controllers
{
    [Authorize]
    public class CommentController : ApiController
    {
        public IHttpActionResult Get()
        {
            CommentService commentService = CreateCommentService();
            var comments = commentService.GetComments();
            return Ok(comments);
        }


    }
}
