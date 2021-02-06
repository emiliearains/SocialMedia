using SocialMedia.Data;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Services
{
    public class CommentService
    {
        private readonly Guid _userId;
        public CommentService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateComment(CreateComment model)
        {
            var entity = new Comment()
            {
                PostId = model.PostId,
                AuthorId = _userId,
                Text = model.Text,
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Comments.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CommentListItem> GetComments(PostAndComments postId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Comments
                    //.Where(e => e.AuthorId == _userId)
                    .Where (e => e.PostId == postId.PostId)
                    .Select(
                        e =>
                            new CommentListItem
                            {
                                PostId = e.PostId,
                                Text = e.Text,
                                CommentId = e.CommentId
                            }
                        );
                return query.ToArray();
            }
        }
        public IEnumerable<CommentListItem> GetPostComments(int PostId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = 
                    ctx
                    .Comments
                    .Where(e => e.PostId == PostId)
                    .Select(
                        e =>
                        new CommentListItem
                        {
                            PostId = e.PostId,
                            Text = e.Text
                        }
                    );
                return query.ToArray();
            }
        }
      
    }
}
